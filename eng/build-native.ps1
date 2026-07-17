[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [ValidateSet('win-x86', 'win-x64', 'win-arm64')]
    [string]$Rid,

    [ValidateSet('Debug', 'Release')]
    [string]$Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$buildDirectory = Join-Path $repoRoot "artifacts/build/$Rid"
$stageDirectory = Join-Path $repoRoot "artifacts/package/runtimes/$Rid/native"
$architecture = switch ($Rid) {
    'win-x86'   { 'Win32' }
    'win-x64'   { 'x64' }
    'win-arm64' { 'ARM64' }
}
$hostArchitecture = [System.Runtime.InteropServices.RuntimeInformation]::ProcessArchitecture.ToString().ToLowerInvariant()
$hostRid = "win-$hostArchitecture"

Push-Location $repoRoot
try {
    if ($Rid -eq $hostRid -and $env:CI -ne 'true') {
        cmake -S native -B $buildDirectory -G Ninja `
            "-DCMAKE_BUILD_TYPE=$Configuration"
        if ($LASTEXITCODE -ne 0) { throw 'CMake configure failed.' }

        cmake --build $buildDirectory --parallel
        if ($LASTEXITCODE -ne 0) { throw 'Native build failed.' }
        $nativeLibrary = Join-Path $buildDirectory 'miniaudio.dll'
    }
    else {
        cmake -S native -B $buildDirectory -G 'Visual Studio 17 2022' -A $architecture
        if ($LASTEXITCODE -ne 0) { throw 'CMake configure failed.' }

        cmake --build $buildDirectory --config $Configuration --parallel
        if ($LASTEXITCODE -ne 0) { throw 'Native build failed.' }
        $nativeLibrary = Join-Path $buildDirectory "$Configuration/miniaudio.dll"
    }

    New-Item -ItemType Directory -Force $stageDirectory | Out-Null
    Copy-Item -LiteralPath $nativeLibrary -Destination (Join-Path $stageDirectory 'miniaudio.dll') -Force
    Write-Host "Staged $Rid native library in $stageDirectory"
}
finally {
    Pop-Location
}
