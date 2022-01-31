$name=(Get-AppxPackage -Name "*HeightGained*").PackageFamilyName
$result = Start-Process explorer.exe shell:AppsFolder\$name!App
Write-Host $result

sleep 5
# get heightGainedApp process
$heightGainedApp = Get-Process HeightGained -ErrorAction SilentlyContinue
if ($Null -eq $heightGainedApp) {
    exit -1
}
exit 0
