
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

    dotnet publish -f $dotnetVersion -r $platform

    $publishFiles = (Get-ChildItem -Path "SuperSize/bin/Release/$dotnetVersion/publish").FullName
    Compress-Archive `
        -Force `
        -LiteralPath $publishFiles `
        -DestinationPath "Releases/$platform"`
}