#!/usr/bin/env bash
set -euo pipefail

if [[ $# -lt 1 ]]; then
    echo "usage: $0 <rid> [Debug|Release]" >&2
    exit 2
fi

rid=$1
configuration=${2:-Release}
repo_root=$(CDPATH= cd -- "$(dirname -- "$0")/.." && pwd)
build_dir="$repo_root/artifacts/build/$rid"
stage_dir="$repo_root/artifacts/package/runtimes/$rid/native"

case "$rid" in
    linux-x64|linux-arm64)
        library_name=libminiaudio.so
        ;;
    linux-musl-x64|linux-musl-arm64)
        library_name=libminiaudio.so
        no_pthread_in_header=true
        ;;
    osx-x64)
        library_name=libminiaudio.dylib
        osx_architecture=x86_64
        ;;
    osx-arm64)
        library_name=libminiaudio.dylib
        osx_architecture=arm64
        ;;
    *)
        echo "unsupported host RID: $rid" >&2
        exit 2
        ;;
esac

cmake_args=(
    -S "$repo_root/native"
    -B "$build_dir"
    -DCMAKE_BUILD_TYPE="$configuration"
)

if command -v ninja >/dev/null 2>&1; then
    cmake_args+=(-G Ninja)
fi
if [[ -n "${CC:-}" ]]; then
    cmake_args+=("-DCMAKE_C_COMPILER=$CC")
fi
if [[ -n "${osx_architecture:-}" ]]; then
    cmake_args+=("-DCMAKE_OSX_ARCHITECTURES=$osx_architecture" "-DCMAKE_OSX_DEPLOYMENT_TARGET=13.0")
fi
if [[ "${no_pthread_in_header:-false}" == true ]]; then
    cmake_args+=("-DMINIAUDIO_CS_NO_PTHREAD_IN_HEADER=ON")
fi

cmake "${cmake_args[@]}"
cmake --build "$build_dir" --parallel

mkdir -p "$stage_dir"
cp "$build_dir/$library_name" "$stage_dir/$library_name"
echo "Staged $rid native library in $stage_dir"
