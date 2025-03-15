using Microsoft.Win32;
using System;

namespace SuperSize.OS;

/// <summary>
/// Helpers utilities to help with starting the application when Windows boots in.
/// </summary>
public static class SystemStartup
{
    private static string RegistryValueName => "SuperSize";

    private static RegistryKey StartupRegKey => Registry.CurrentUser?.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true)!;

    private static string ExecutablePath => Environment.ProcessPath!;

    /// <summary>
    /// Register the application for startup.
    /// </summary>
    public static void Register()
    {
        StartupRegKey.SetValue(RegistryValueName, ExecutablePath);
    }

    /// <summary>
    /// Unregister the applicatiom from startup.
    /// </summary>
    public static void Unregister()
    {
        StartupRegKey.DeleteValue(RegistryValueName);
    }

    /// <summary>
    /// Check if the application registration is current.
    /// </summary>
    public static bool IsRegistered() => StartupRegKey.GetValue(RegistryValueName, "").ToString() == ExecutablePath;
}
