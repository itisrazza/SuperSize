using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SuperSize.PluginBase;
using System.Drawing;
using System.Windows.Forms;
using SuperSize.CoreLogic;

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

        private static List<Plugin>? _plugins = null;

        /// <summary>
        /// Available plugins.
        /// </summary>
        public static IEnumerable<Plugin> Plugins
        {
            get
            {
                return _plugins ?? UpdatePlugins();
            }
        }

        public static Logic NullLogic { get; } = new NullLogicImpl();

        private static List<Plugin> UpdatePlugins()
        {
            _plugins = GetPlugins();
            return _plugins;
        }

        /// <summary>
        /// Return a list of available plugins.
        /// </summary>
        /// <returns></returns>
        public static List<Plugin> GetPlugins()
        {
            return SearchLocations
                .SelectMany(location => Directory.EnumerateFiles(location, "*.dll", SearchOption.AllDirectories))
                .SelectMany(dllFiles => GetPlugins(dllFiles))
                .Prepend(new CoreLogic.CoreLogic())
                .ToList();
        }

        /// <summary>
        /// Retrieves the plugin from a file.
        /// </summary>
        /// <param name="dllPath">Path to DLL.</param>
        /// <returns>Plugin information.</returns>
        public static IEnumerable<Plugin> GetPlugins(string dllPath)
        {
            return GetPluginsFromAssembly(Assembly.LoadFile(dllPath));
        }

        public static void InstallPlugin(string dllPath)
        {
            _plugins ??= UpdatePlugins();

            var plugins = GetPlugins(dllPath);
            File.Copy(dllPath, Path.Join(UserPluginFolder, Path.GetFileName(dllPath)), true);
            _plugins.AddRange(plugins);
        }

        /// <summary>
        /// Retrieves the plugin from an assembly.
        /// </summary>
        /// <param name="assembly">Plugin to retrieve.</param>
        /// <exception cref="EntryPointNotFoundException" />
        private static IEnumerable<Plugin> GetPluginsFromAssembly(Assembly assembly)
        {
            try
            {
                return GetPluginTypes(assembly).Select(type => Activator.CreateInstance(type) as Plugin ?? throw new InvalidCastException());
            }
            catch (Exception ex)
            {
                throw new PluginFailureException(assembly.Location, "Failed to load plugin assembly and information.", ex);
            }
        }

        /// <summary>
        /// Retrives the plugin information class from the assembly.
        /// </summary>
        /// <param name="assembly">Assembly to retrieve class from.</param>
        /// <returns><see cref="Type"/> extending <see cref="Plugin"/>.</returns>
        /// <exception cref="EntryPointNotFoundException" />
        private static IEnumerable<Type> GetPluginTypes(Assembly assembly)
        {
            return assembly.GetTypes().Where(type => type.BaseType == typeof(Plugin));
        }

        private class NullLogicImpl : Logic
        {
            public override string DisplayName => string.Empty;

            public override Task<Rectangle> CalculateWindowSize(Screen[] screens, Settings settings)
            {
                return Task.FromResult(new Rectangle(0, 0, 800, 600));
            }

            public override void ShowSettings(Settings settings) => DisplayNoSettingsMessage();
        }
    }
}
