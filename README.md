# Miniaudio-CS

Direct C# bindings for [miniaudio](https://github.com/mackron/miniaudio), generated with
[ClangSharp](https://github.com/dotnet/ClangSharp). The upstream repository is kept as a Git
submodule so updating and regenerating the binding is repeatable.

The public API intentionally mirrors miniaudio. Functions are exposed from the generated `MA`
class, while native types retain their upstream `ma_*` names.

```csharp
using Miniaudio;
using System.Text;

unsafe
{
    var config = MA.ma_engine_config_init();
    ma_engine engine = default;

    if (MA.ma_engine_init(&config, &engine) != ma_result.MA_SUCCESS)
        throw new InvalidOperationException("Could not initialize miniaudio.");

    try
    {
        var path = Encoding.UTF8.GetBytes("sound.wav\0");
        fixed (byte* pPath = path)
        {
            MA.ma_engine_play_sound(&engine, (sbyte*)pPath, null);
        }
    }
    finally
    {
        MA.ma_engine_uninit(&engine);
    }
}
```

## Build locally

```powershell
git submodule update --init --recursive
./eng/build-native.ps1 -Rid win-x64
./eng/generate-bindings.ps1
dotnet build Miniaudio.sln -c Release
dotnet run --project tests/Miniaudio.SmokeTests -c Release
```

On Unix, use `bash eng/build-native.sh <rid>` and `bash eng/generate-bindings.sh`.

## Runtime coverage

The GitHub Actions matrix builds platform-matched managed bindings and native libraries for:

| Family | Runtime identifiers |
| --- | --- |
| Windows | `win-x86`, `win-x64`, `win-arm64` |
| Linux glibc | `linux-x64`, `linux-arm`, `linux-arm64` |
| Linux musl | `linux-musl-x64`, `linux-musl-arm64` |
| macOS | `osx-x64`, `osx-arm64` |
| Android | `android-x86`, `android-x64`, `android-arm`, `android-arm64` |
| iOS | `ios-arm64`, `iossimulator-x64`, `iossimulator-arm64` |
| tvOS | `tvos-arm64`, `tvossimulator-x64`, `tvossimulator-arm64` |
| WebAssembly | `browser-wasm` |

Desktop, Linux, and Android use shared libraries. Apple mobile platforms use static archives wired
into consuming applications through `NativeReference`. Browser WebAssembly is compiled from the
packaged upstream C source through `NativeFileReference`, ensuring its Emscripten version matches
the consuming .NET workload.

The native dynamic library keeps the upstream name (`miniaudio`); the managed assembly is named
`MiniaudioSharp` to avoid a filename collision with `miniaudio.dll` on Windows.

## Update miniaudio

```powershell
./eng/update-miniaudio.ps1 -Ref <tag-or-commit>
```

Commit both the submodule pointer and regenerated binding. CI verifies that the generated source
matches the checked-in header and that the native and managed version numbers agree.
The submodule also tracks the upstream `master` branch for `git submodule update --remote`, and
Dependabot checks it weekly.

## Platform note

Several public miniaudio structures contain platform-backend-specific fields. The NuGet package
therefore contains RID-specific `MiniaudioSharp.dll` runtime assets alongside the matching native
library. Do not manually mix assemblies and native libraries produced for different
platform/architecture ABIs.

This is deliberately a raw binding: object lifetime, callback lifetime, UTF-8 conversion, and
threading follow the upstream C API and remain the caller's responsibility.
