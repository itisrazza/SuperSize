
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

    cd SuperSize
    dotnet publish -c $configuration -f $dotnetVersion -r $platform
    cd ..

    $publishFiles = (Get-ChildItem -Path "SuperSize/bin/Release/$dotnetVersion/$platform").FullName
    Compress-Archive `
        -Force `
        -LiteralPath $publishFiles `
        -DestinationPath "Releases/$platform"`
}
