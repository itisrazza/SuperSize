
function Get-ProjectVersion () {
    Select-Xml -Path SuperSize/SuperSize.csproj -XPath '/Project/PropertyGroup/Version' |
        ForEach-Object {
            $_.Node.InnerXML
        }
}
