$name=(Get-AppxPackage -Name "*HeightGained*").PackageFamilyName
$result = Start-Process -FilePath shell:AppsFolder\$name!App -Verbose
Write-Host $result

sleep 5
# get heightGainedApp process
$heightGainedApp = Get-Process HeightGained -ErrorAction SilentlyContinue
if ($Null -eq $heightGainedApp) {
    exit -1
}
exit 0
