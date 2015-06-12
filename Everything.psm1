Set-StrictMode -Version Latest

Add-Type -Path (Join-Path $PSScriptRoot "SDK\Voidtools.Everything.SDK.dll")

[Voidtools.Everything.Loader]::LoadNativeDll()

. (Join-Path $PSScriptRoot "Find-FileFromEverything.ps1")