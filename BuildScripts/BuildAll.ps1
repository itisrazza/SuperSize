
$configuration = "Release"
$dotnetVersion = "net5.0-windows"
$targetPlatforms = @(
    "win-x86"
    "win-x64"
    # "win-arm"
    # "win-arm64"
)

# create a releases folder
New-Item -ItemType "directory" -Path "Releases" -Force

# build for every platform
foreach ($platform in $targetPlatforms) {
    echo ""
    echo ""
    echo "++ BUILDING FOR $platform"

    echo " + Creating fat executables for portable ZIPs"
    cd SuperSize
    rm -Recurse -Force "bin/Release/$dotnetVersion/$platform"
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
    rm -Recurse -Force "bin/Release/$dotnetVersion/$platform"
    dotnet publish -c $configuration -f $dotnetVersion -r $platform --self-contained false
    cd ..
}

# build the installer
