$name=(Get-AppxPackage -Name "*HeightGained*").PackageFullName
Remove-AppPackage -Package $name
