using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SuperSize.Plugin;

namespace SuperSize.Service
{
    public class PluginService
    {
        /// <summary>
        /// The application plugin folder. If installed, this will be system-wide,
        /// or if portable, this will move with the application.
        /// </summary>
        public static string ApplicationPluginFolder { get; } = Path.Join(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
            "Plugins"
        );

        /// <summary>
        /// The user plugin folder. The plugins will move with the user.
        /// </summary>
        public static string UserPluginFolder { get; } = Path.Join(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "SuperSize",
            "Plugins"
        );

        /// <summary>
        /// Known search locations.
        /// </summary>
        public static ImmutableList<string> SearchLocations { get; } = ImmutableList.Create(
            ApplicationPluginFolder,
            UserPluginFolder
        );

        private static IEnumerable<PluginBase>? _plugins = null;

        /// <summary>
        /// Available plugins.
        /// </summary>
        public static IEnumerable<PluginBase> Plugins
        {
            get
            {
                return _plugins ?? UpdatePlugins();
            }
        }

        private static IEnumerable<PluginBase> UpdatePlugins()
        {
            _plugins = GetPlugins();
            return _plugins;
        }

        /// <summary>
        /// Return a list of available plugins.
        /// </summary>
        /// <returns></returns>
        public static List<PluginBase> GetPlugins()
        {
            var plugins = new List<PluginBase>();
            foreach (var searchLocation in SearchLocations)
            {
                foreach (var file in Directory.EnumerateFiles(searchLocation, "*.dll", SearchOption.AllDirectories))
                {
                    plugins.Add(GetPlugin(file));
                }
            }
            return plugins;
        }

        /// <summary>
        /// Retrieves the plugin from a file.
        /// </summary>
        /// <param name="dllPath">Path to DLL.</param>
        /// <returns>Plugin information.</returns>
        public static PluginBase GetPlugin(string dllPath)
        {
            return GetPluginFromAssembly(Assembly.LoadFile(dllPath));
        }

        /// <summary>
        /// Retrieves the plugin from an assembly.
        /// </summary>
        /// <param name="assembly">Plugin to retrieve.</param>
        /// <exception cref="EntryPointNotFoundException" />
        private static PluginBase GetPluginFromAssembly(Assembly assembly)
        {
            var pluginClass = GetPluginClass(assembly);
            var pluginBase = Activator.CreateInstance(pluginClass) as PluginBase;
            return pluginBase ?? throw new NullReferenceException();
        }

        /// <summary>
        /// Retrives the plugin information class from the assembly.
        /// </summary>
        /// <param name="assembly">Assembly to retrieve class from.</param>
        /// <returns><see cref="Type"/> extending <see cref="PluginBase"/>.</returns>
        /// <exception cref="EntryPointNotFoundException" />
        private static Type GetPluginClass(Assembly assembly)
        {
            try
            {
                return assembly.GetTypes()
                    .Where(type => type.Name == "Plugin" && type.BaseType == typeof(PluginBase))
                    .First();
            }
            catch (InvalidOperationException e)
            {
                throw new EntryPointNotFoundException("The assembly is missing a Plugin class extending PluginBase.", e);
            }
        }
    }
}
