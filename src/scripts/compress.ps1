# Pass in as arguments:
# param 1: root folder absolute path contain AppPackages, scripts and bin folders
# param 2: name of the folder inside AppPackages that contains the msixbundle file for the app

$root = $args[0]
$msixfolder = $root + "/AppPackages/" + $args[1]
$binfolder= $root + "/bin"
$scriptsfolder = $root +"/scripts"

Compress-Archive -Path $msixfolder\Add-AppDevPackage.resources, $msixfolder\Dependencies\*, $msixfolder\HeightGained*, $scriptsfolder\*.ps1 -DestinationPath $binfolder\HeightGained_uwp.zip -Force