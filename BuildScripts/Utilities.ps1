$PSDefaultParameterValues['Out-File:Encoding'] = 'utf8'

$targetPlatforms = @(
    "win-x86"
    "win-x64"
    # "win-arm"
    # "win-arm64"
)

function Get-ProjectVersion () {
    Select-Xml -Path SuperSize/SuperSize.csproj -XPath '/Project/PropertyGroup/Version' |
        ForEach-Object {
            $_.Node.InnerXML
        }
}
