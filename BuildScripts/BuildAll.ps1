. .\BuildScripts\Utilities.ps1

$configuration = "Release"
$dotnetVersion = "net8.0-windows"

# create a releases folder
if (-not(Test-Path "Releases")) { New-Item -ItemType "directory" -Path "Releases" -Force }


# build for every platform
foreach ($platform in Get-TargetPlatforms) {
    Write-Output ""
    Write-Output ""
    Write-Output "++ BUILDING FOR $platform"

    Write-Output " + Creating slim executables"
    Set-Location SuperSize
    if (Test-Path "bin/Release/$dotnetVersion/$platform") { Remove-Item -Recurse -Force "bin/Release/$dotnetVersion/$platform" }
    dotnet publish -c $configuration -f $dotnetVersion -r $platform --self-contained false
    Set-Location ..

    Write-Output " + Creating slim ZIP"
    $publishFiles = (Get-ChildItem -Path "SuperSize/bin/Release/$dotnetVersion/$platform/publish").FullName
    Compress-Archive `
        -Force `
        -LiteralPath $publishFiles `
        -DestinationPath "Releases/$platform-slim.zip"`

    Write-Output " + Creating self-contained executables"
    Set-Location SuperSize
    if (Test-Path "bin/Release/$dotnetVersion/$platform") { Remove-Item -Recurse -Force "bin/Release/$dotnetVersion/$platform" }
    dotnet publish -c $configuration -f $dotnetVersion -r $platform --self-contained true
    Set-Location ..

    Write-Output " + Creating self-contained ZIP"
    $publishFiles = (Get-ChildItem -Path "SuperSize/bin/Release/$dotnetVersion/$platform/publish").FullName
    Compress-Archive `
        -Force `
        -LiteralPath $publishFiles `
        -DestinationPath "Releases/$platform-selfcontained.zip"`

}
