[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$Rid,

    [ValidateSet('Debug', 'Release')]
    [string]$Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$source = Join-Path $repoRoot "src/Miniaudio/bin/$Configuration/net8.0/MiniaudioSharp.dll"
$destination = Join-Path $repoRoot "artifacts/package/runtimes/$Rid/lib/net8.0"

if (-not (Test-Path -LiteralPath $source)) {
    throw "Managed binding has not been built: $source"
}

New-Item -ItemType Directory -Force $destination | Out-Null
Copy-Item -LiteralPath $source -Destination (Join-Path $destination 'MiniaudioSharp.dll') -Force
Write-Host "Staged $Rid managed binding in $destination"
