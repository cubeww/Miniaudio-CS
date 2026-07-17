[CmdletBinding()]
param(
    [switch]$Check,
    [string]$TargetTriple,
    [string]$SysRoot,
    [string]$ResourceDirectory,
    [string[]]$DefineMacro,
    [string[]]$AdditionalClangArgument,
    [string]$LibraryPath
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$generatedFile = Join-Path $repoRoot 'src/Miniaudio/Generated/Miniaudio.g.cs'
$backupFile = [System.IO.Path]::GetTempFileName()
$hadGeneratedFile = Test-Path $generatedFile

if ($hadGeneratedFile) {
    Copy-Item -LiteralPath $generatedFile -Destination $backupFile -Force
}

Push-Location $repoRoot
try {
    dotnet tool restore
    if ($LASTEXITCODE -ne 0) { throw 'dotnet tool restore failed.' }

    $generatorArgs = @('@eng/generate.rsp')

    if (-not $ResourceDirectory) {
        $clang = Get-Command clang -ErrorAction SilentlyContinue
        if ($clang) {
            $detectedResourceDirectory = (& $clang.Source -print-resource-dir).Trim()
            if ($LASTEXITCODE -eq 0 -and (Test-Path -LiteralPath $detectedResourceDirectory -PathType Container)) {
                $ResourceDirectory = $detectedResourceDirectory
            }
        }
    }
    if ($ResourceDirectory) {
        $generatorArgs += "--resource-directory=$ResourceDirectory"
    }
    if ($TargetTriple) {
        $generatorArgs += "--additional=--target=$TargetTriple"
    }
    if ($SysRoot) {
        $generatorArgs += "--additional=--sysroot=$SysRoot"
    }
    foreach ($argument in $AdditionalClangArgument) {
        $generatorArgs += "--additional=$argument"
    }
    foreach ($macro in $DefineMacro) {
        $generatorArgs += "--define-macro=$macro"
    }
    if ($LibraryPath) {
        $generatorArgs += "--library-path=$LibraryPath"
    }

    dotnet tool run ClangSharpPInvokeGenerator -- @generatorArgs
    if ($LASTEXITCODE -ne 0) {
        if ($hadGeneratedFile) {
            Copy-Item -LiteralPath $backupFile -Destination $generatedFile -Force
        }
        throw 'ClangSharp binding generation failed.'
    }

    if ($Check) {
        git diff --exit-code -- $generatedFile
        if ($LASTEXITCODE -ne 0) {
            throw 'Generated bindings are stale. Run eng/generate-bindings.ps1 and commit the result.'
        }
    }
}
finally {
    Pop-Location
    Remove-Item -LiteralPath $backupFile -Force -ErrorAction SilentlyContinue
}
