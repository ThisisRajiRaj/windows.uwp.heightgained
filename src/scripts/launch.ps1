$name=(Get-AppxPackage -Name "*HeightGained*").InstallLocation
Write-Host $name
Get-ChildItem -Path $name
Start-Process -FilePath $name\HeightGained.exe -Verbose

Write-Host "Starting to sleep"
Start-Sleep -s 10

Write-Host "Starting to look for process"
if (Get-Process -Name HeightGained) {
    Write-Host "Returing 0"
    exit 0
}
Write-Host "Returing -1"
exit -1