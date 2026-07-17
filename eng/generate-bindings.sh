#!/usr/bin/env bash
set -eu

repo_root=$(CDPATH= cd -- "$(dirname -- "$0")/.." && pwd)
cd "$repo_root"

generated_file=src/Miniaudio/Generated/Miniaudio.g.cs
backup_file=$(mktemp)
had_generated=false
if [[ -f "$generated_file" ]]; then
    cp "$generated_file" "$backup_file"
    had_generated=true
fi
trap 'rm -f "$backup_file"' EXIT

dotnet tool restore

args=(@eng/generate.rsp)
if [[ -n "${CLANG_TARGET:-}" ]]; then
    args+=("--additional=--target=$CLANG_TARGET")
fi
if [[ -n "${CLANG_RESOURCE_DIR:-}" ]]; then
    args+=("--resource-directory=$CLANG_RESOURCE_DIR")
elif [[ -n "${CLANG_TARGET:-}" ]]; then
    resource_dir=$(clang -print-resource-dir)
    args+=("--resource-directory=$resource_dir")
fi
if [[ -n "${CLANG_SYSROOT:-}" ]]; then
    args+=("--additional=--sysroot=$CLANG_SYSROOT")
fi
if [[ -n "${CLANG_ADDITIONAL:-}" ]]; then
    for argument in $CLANG_ADDITIONAL; do
        args+=("--additional=$argument")
    done
fi
if [[ -n "${MINIAUDIO_DEFINES:-}" ]]; then
    for macro in $MINIAUDIO_DEFINES; do
        args+=("--define-macro=$macro")
    done
fi
if [[ -n "${MINIAUDIO_LIBRARY_PATH:-}" ]]; then
    args+=("--library-path=$MINIAUDIO_LIBRARY_PATH")
fi
if [[ -n "${CLANG_TRAVERSE_ROOTS:-}" ]]; then
    IFS=':' read -r -a traverse_roots <<< "$CLANG_TRAVERSE_ROOTS"
    for root in "${traverse_roots[@]}"; do
        [[ -d "$root" ]] || continue
        while IFS= read -r -d '' header; do
            args+=("--traverse=$header")
        done < <(
            find "$root" -type f \( \
                -name '*pthread*types*.h' -o \
                -name 'thread-shared-types.h' -o \
                -name 'atomic_wide_counter.h' -o \
                -name 'struct_mutex.h' -o \
                -name 'struct_rwlock.h' -o \
                -name 'alltypes.h' -o \
                -path '*/sys/_pthread/*.h' \
            \) -print0
        )
    done
fi

set +e
dotnet tool run ClangSharpPInvokeGenerator -- "${args[@]}"
generator_status=$?
set -e

# ClangSharp uses exit code 2 when generation completed with warnings. System
# headers commonly contain function-like initializer macros that it cannot bind,
# but the requested type declarations are still emitted successfully.
if (( generator_status != 0 && generator_status != 2 )); then
    if [[ "$had_generated" == true ]]; then
        cp "$backup_file" "$generated_file"
    fi
    exit "$generator_status"
fi

if [ "${1:-}" = "--check" ]; then
    git diff --exit-code -- "$generated_file"
fi
