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
    resource_dir=${CLANG_RESOURCE_DIR:-$(clang -print-resource-dir)}
    args+=("--resource-directory=$resource_dir" "--additional=--target=$CLANG_TARGET")
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

if ! dotnet tool run ClangSharpPInvokeGenerator -- "${args[@]}"; then
    if [[ "$had_generated" == true ]]; then
        cp "$backup_file" "$generated_file"
    fi
    exit 1
fi

if [ "${1:-}" = "--check" ]; then
    git diff --exit-code -- "$generated_file"
fi
