[CmdletBinding()]
param(
    [string]$Ref = 'origin/master'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot

Push-Location $repoRoot
try {
    git submodule update --init --recursive
    if ($LASTEXITCODE -ne 0) { throw 'Could not initialize the miniaudio submodule.' }

    git -C external/miniaudio fetch origin --tags
    if ($LASTEXITCODE -ne 0) { throw 'Could not fetch miniaudio.' }

    git -C external/miniaudio checkout $Ref
    if ($LASTEXITCODE -ne 0) { throw "Could not check out miniaudio ref '$Ref'." }

    & "$PSScriptRoot/generate-bindings.ps1"
    if ($LASTEXITCODE -ne 0) { throw 'Could not regenerate the binding.' }

    git -C external/miniaudio describe --tags --always
    Write-Host 'Review and commit the submodule pointer together with the generated binding.'
}
finally {
    Pop-Location
}
