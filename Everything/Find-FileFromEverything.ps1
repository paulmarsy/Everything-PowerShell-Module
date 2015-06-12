function Find-FileFromEverything {
    [CmdletBinding()]
    param(
        [Parameter(Mandatory=$true)]
        $Query,
        [switch]$Paging
    )
    
    [Voidtools.Everything.SDK]::Everything_SetSearchW($Query)
	
    [Voidtools.Everything.SDK]::Everything_QueryW($true) | Out-Null
    [Voidtools.Everything.SDK]::Everything_SortResultsByPath()

    $numberOfResults = [Voidtools.Everything.SDK]::Everything_GetNumResults()

    Write-Host -ForegroundColor Green "Number of results: $numberOfResults"
    Write-Host
	
    $bufferSize = 255
	$buffer = New-Object -Type System.Text.StringBuilder -ArgumentList $bufferSize
    0..$numberOfResults | % {
        [Voidtools.Everything.SDK]::Everything_GetResultFullPathNameW($_, $buffer, $bufferSize) | Out-Null
        Write-Output ($buffer.ToString())
	} | Out-Host -Paging:$Paging
}