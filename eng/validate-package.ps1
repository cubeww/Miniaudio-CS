[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$PackagePath,

    [string[]]$RequiredRid = @(
        'win-x86', 'win-x64', 'win-arm64',
        'linux-x64', 'linux-arm', 'linux-arm64',
        'linux-musl-x64', 'linux-musl-arm64',
        'osx-x64', 'osx-arm64',
        'android-x86', 'android-x64', 'android-arm', 'android-arm64',
        'ios-arm64', 'iossimulator-x64', 'iossimulator-arm64',
        'tvos-arm64', 'tvossimulator-x64', 'tvossimulator-arm64',
        'browser-wasm'
    )
)

$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.IO.Compression.FileSystem

$resolvedPackage = (Resolve-Path -LiteralPath $PackagePath).Path
$archive = [System.IO.Compression.ZipFile]::OpenRead($resolvedPackage)
try {
    $entries = @($archive.Entries | ForEach-Object { $_.FullName.Replace('\', '/') })

    if ($entries -notcontains 'lib/net8.0/MiniaudioSharp.dll') {
        throw 'The package does not contain its compile-time managed assembly.'
    }
    if ($entries -notcontains 'buildTransitive/Miniaudio.CSharp.targets') {
        throw 'The package does not contain the Apple static-library integration target.'
    }
    if ($entries -notcontains 'build/native/miniaudio/miniaudio.c') {
        throw 'The package does not contain the browser-wasm native source asset.'
    }

    foreach ($rid in $RequiredRid) {
        $managed = "runtimes/$rid/lib/net8.0/MiniaudioSharp.dll"
        $nativePrefix = "runtimes/$rid/native/"

        if ($entries -notcontains $managed) {
            throw "Missing RID-specific managed binding: $managed"
        }
        if (-not ($entries | Where-Object { $_.StartsWith($nativePrefix) -and -not $_.EndsWith('/') })) {
            throw "Missing native library under $nativePrefix"
        }
    }

    Write-Host "Validated $($RequiredRid.Count) runtime payloads in $resolvedPackage"
}
finally {
    $archive.Dispose()
}
