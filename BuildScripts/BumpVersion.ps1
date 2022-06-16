. .\BuildScripts\Utilities.ps1

$version = Get-ProjectVersion
$jump = "patch"                 # version part to bump

# figure out what to do with argument

if ($args[0] -match '^(\d)\.(\d)\.(\d)\.(\d)$') {
    # if the argument is a  version number, use it
    $version = $args[0]
    $jump = "none"
} else {
    # if the argument is a jump type, use it
    switch ($args[0]) {
        "major" { $jump = "major" }
        "minor" { $jump = "minor" }
        "patch" { $jump = "patch" }
        "build" { $jump = "build" }
        Default {  } # if default, leave as is
    }
}

# bump the version number

$nums = $version.Split(".")
$major = [int]$nums[0]
$minor = [int]$nums[1]
$patch = [int]$nums[2]
$build = [int]$nums[3]

switch ($jump) {
    "major" { $major++; $minor = 0; $patch = 0; $build = 0 }
    "minor" { $minor++; $patch = 0; $build = 0 }
    "patch" { $patch++; $build = 0 }
    "build" { $build++ }
    default {}  # do nothing for default
}

$version = "$major.$minor.$patch.$build"

Write-Host "version = $version"
Write-Host "jump    = $jump"
Write-Host

# write to project files

[xml] $mainProj = Get-Content "SuperSize\SuperSize.csproj"
[xml] $pluginSdkProj = Get-Content "SuperSize.PluginBase\SuperSize.PluginBase.csproj"
[xml] $coreLogicProj = Get-Content "SuperSize.CoreLogic\SuperSize.CoreLogic.csproj"

$mainProj.Project.PropertyGroup.Version = $version
$mainProj.Project.PropertyGroup.FileVersion = $version
$mainProj.Project.PropertyGroup.InformationalVersion = $version

$pluginSdkProj.Project.PropertyGroup.Version = $version
$coreLogicProj.Project.PropertyGroup.Version = $version

$mainProj.PreserveWhitespace = $true
$pluginSdkProj.PreserveWhitespace = $true
$coreLogicProj.PreserveWhitespace = $true

$dir = Get-Location
$mainProj.Save("$dir\SuperSize\SuperSize.csproj")
$pluginSdkProj.Save("$dir\SuperSize.PluginBase\SuperSize.PluginBase.csproj")
$coreLogicProj.Save("$dir\SuperSize.CoreLogic\SuperSize.CoreLogic.csproj")
