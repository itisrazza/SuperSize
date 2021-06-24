using SuperSize.Plugin;
using Config = SuperSize.Plugin.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace SuperSize.Service
{
    public class ConfigService
    {
        private static IConfigProvider _configProvider = new ConfigProvider();

        /// <summary>
        /// Get the config provider for the plugins.
        /// </summary>
        public static IConfigProvider GetConfigProvider() => _configProvider;

        /// <summary>
        /// Load the 
        /// </summary>
        /// <returns></returns>
        public static Config.Object Load()
        {
            return JsonSerializer.Deserialize<Config.Object>(Properties.Settings.Default.LogicConfig) ?? new Config.Object();
        }

        public static void Save(Config.Object obj)
        {
            Properties.Settings.Default.LogicConfig = JsonSerializer.Serialize(obj);
            Properties.Settings.Default.Save();
        }

        private class ConfigProvider : IConfigProvider
        {
            public Config.Object GetConfig() => Load();

            public void SaveConfig(Config.Object config) => Save(config);
        }
    }
}
