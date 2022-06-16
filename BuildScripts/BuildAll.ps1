. .\BuildScripts\Utilities.ps1

$configuration = "Release"
$dotnetVersion = "net5.0-windows"
$targetPlatforms = @(
    "win-x86"
    "win-x64"
    # "win-arm"
    # "win-arm64"
)

# create a releases folder
if (-not(Test-Path "Releases")) { New-Item -ItemType "directory" -Path "Releases" -Force }
if (-not(Test-Path "Releases/Plugins")) { New-Item -ItemType "directory" -Path "Releases/Plugins" -Force }

# build cross-platform release for plugin SDK library
echo ""
echo ""
echo "++ BUILDING SDK PLUGIN"
cd SuperSize.PluginBase
if (Test-Path "bin/$configuration/$dotnetVersion/publish") { Remove-Item -Recurse -Force "bin/$configuration/$dotnetVersion/publish" }
dotnet publish -c $configuration -f $dotnetVersion
dotnet pack -c $configuration
cp "bin/Release/$dotnetVersion/publish/SuperSize.PluginBase.dll" "../Releases/Plugins"
cd ..

# build cross-platform release for core logic library
echo ""
echo ""
echo "++ BUILDING BUILT-IN PLUGIN"
cd SuperSize.CoreLogic
if (Test-Path "bin/$configuration/$dotnetVersion/publish") { Remove-Item -Recurse -Force "bin/$configuration/$dotnetVersion/publish" }
dotnet publish -c $configuration -f $dotnetVersion
cp "bin/Release/$dotnetVersion/publish/SuperSize.CoreLogic.dll" "../Releases/Plugins"
cd ..


# build for every platform
foreach ($platform in $targetPlatforms) {
    echo ""
    echo ""
    echo "++ BUILDING FOR $platform"

    echo " + Creating fat executables for portable ZIPs"
    cd SuperSize
    if (Test-Path "bin/Release/$dotnetVersion/$platform") { Remove-Item -Recurse -Force "bin/Release/$dotnetVersion/$platform" }
    dotnet publish -c $configuration -f $dotnetVersion -r $platform --self-contained true
    cd ..

    echo " + Creating portable ZIP"
    $publishFiles = (Get-ChildItem -Path "SuperSize/bin/Release/$dotnetVersion/$platform").FullName
    Compress-Archive `
        -Force `
        -LiteralPath $publishFiles `
        -DestinationPath "Releases/$platform-portable.zip"`

    echo " + Creating slim executables to be picked up by installer"
    cd SuperSize
    if (Test-Path "bin/Release/$dotnetVersion/$platform") { Remove-Item -Recurse -Force "bin/Release/$dotnetVersion/$platform" }
    dotnet publish -c $configuration -f $dotnetVersion -r $platform --self-contained false
    cd ..
}
