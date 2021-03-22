. .\BuildScripts\Utilities.ps1

$innoPath = "C:\Program Files (x86)\Inno Setup 6"
$projectVersion = Get-ProjectVersion
$platform = "win-x86"       # installer is always x86, cbf making x64 or arm64 for now

$runtimeInstallerPath = "Installer/windowsdesktop-runtime-5.0.4-$platform.exe"

# if the .net runtime isn't downloaded, download it
if (-not ( Test-Path -Path $runtimeInstallerPath )) {
    Invoke-WebRequest `
        -Uri "https://download.visualstudio.microsoft.com/download/pr/0c5c56a4-8b34-4361-8af9-482c788b2bcf/d734b200547c8c367eb45ebbd69c4698/windowsdesktop-runtime-5.0.4-win-x86.exe" `
        -OutFile $runtimeInstallerPath
}

# lastly build the installer
& "$innoPath/iscc.exe" `
    /DMyAppVersion="$projectVersion" `
    /DRuntimeInstallerPath="$runtimeInstallerPath" `
    /DAppPlatform="$platform" `
    Installer/Setup.iss

# move the installer to releases
mv -Force "Installer/Output/$platform-installer.exe" "Releases/"
