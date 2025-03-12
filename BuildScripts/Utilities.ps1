$PSDefaultParameterValues['Out-File:Encoding'] = 'utf8'

function Get-TargetPlatforms () {
    @(
        "win-x64"
        "win-arm64"
    )
}

function Get-ProjectVersion () {
    Select-Xml -Path SuperSize/SuperSize.csproj -XPath '/Project/PropertyGroup/Version' |
    ForEach-Object {
        $_.Node.InnerXML
    }
}
