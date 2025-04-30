using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace SuperSize.OS;

/// <summary>
/// Helpers utilities to help with starting the application when Windows boots in.
/// </summary>
public static class SystemStartup
{
    private static string RegistryValueName => "SuperSize";

    private static string ExecutablePath => Environment.ProcessPath!;

    private static RegistryKey? OpenSubKey(bool writable)
    {
        var baseKey = Registry.CurrentUser;
        if (baseKey is null)
        {
            Debug.Print("There is no current user registry base key");
            return null;
        }

        return baseKey?.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", writable);
    }

    /// <summary>
    /// Register the application for startup.
    /// </summary>
    public static void Register()
    {
        using var key = OpenSubKey(true) ?? throw new Exception("Startup applications registry key doesn't exist.");
        try
        {
            key.SetValue(RegistryValueName, ExecutablePath);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Exception while registering: {0}", ex);
            throw new Exception("Couldn't register to start with Windows", ex);
        }
    }

    /// <summary>
    /// Unregister the applicatiom from startup.
    /// </summary>
    public static void Unregister()
    {
        using var key = OpenSubKey(true) ?? throw new Exception("Startup applications registry key doesn't exist.");
        try
        {
            key.DeleteValue(RegistryValueName);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Exception while unregistering: {0}", ex);
            throw new Exception("Couldn't deregister from starting with Windows.", ex);
        }
    }

    /// <summary>
    /// Check if the application registration is current.
    /// </summary>
    public static bool IsRegistered()
    {
        using var key = OpenSubKey(false);
        if (key is null) return false;

        return key.GetValue(RegistryValueName, "").ToString() == ExecutablePath;
    }
}
