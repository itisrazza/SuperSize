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
using Newtonsoft.Json;

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
            var doc = JsonDocument.Parse(Properties.Settings.Default.LogicConfig);
            if (doc.RootElement.ValueKind != JsonValueKind.Object)
            {
                throw new NotSupportedException("The root element must be an object.");
            }

            return FromJsonObject(doc.RootElement);
        }

        public static void Save(Config.Object obj)
        {
            // FIXME: swap Newtonsoft for actual JSON library if MSFT decides
            //        to make JsonDocument writable

            var sw = new StringWriter();
            using var jw = new JsonTextWriter(sw);
            ToJson(jw, obj);

            Properties.Settings.Default.LogicConfig = sw.ToString();
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Implementation of the config provider interface from the SDK library
        /// </summary>
        private class ConfigProvider : IConfigProvider
        {
            public Config.Object GetConfig() => Load();

            public void SaveConfig(Config.Object config) => Save(config);
        }

        #region JSON <=> Config objects

        private static Config.IElement FromJson(JsonElement element)
        {
            return element.ValueKind switch
            {
                JsonValueKind.Object => FromJsonObject(element),
                JsonValueKind.Array => FromJsonArray(element),
                JsonValueKind.String => FromJsonString(element),
                JsonValueKind.Number => FromJsonNumber(element),
                JsonValueKind.Undefined => Config.Primitive.Null,
                JsonValueKind.True => Config.Primitive.True,
                JsonValueKind.False => Config.Primitive.False,
                JsonValueKind.Null => Config.Primitive.Null,
                _ => throw new NotImplementedException(),
            };
        }

        private static Config.Object FromJsonObject(JsonElement element)
        {
            var obj = new Config.Object();
            var enumerator = element.EnumerateObject();
            while (enumerator.MoveNext())
            {
                obj.Add(enumerator.Current.Name, FromJson(enumerator.Current.Value));
            }
            return obj;
        }

        private static Config.Array FromJsonArray(JsonElement element)
        {
            var arr = new Config.Array();
            var enumerator = element.EnumerateArray();
            while (enumerator.MoveNext())
            {
                arr.Add(FromJson(enumerator.Current));
            }
            return arr;
        }

        private static Config.Primitive FromJsonString(JsonElement element)
        {
            return new(element.GetString() ?? throw new NullReferenceException());
        }

        private static Config.Primitive FromJsonNumber(JsonElement element)
        {
            if (element.TryGetInt32(out var value))
            {
                return new(value);
            }
            else if (element.TryGetSingle(out var single))
            {
                return new(single);
            }

            throw new NotImplementedException("The number cannot be expressed as a Int32 or Single.");
        }

        private static void ToJson(JsonWriter writer, Config.IElement element)
        {
            if (element is Config.Object obj) ToJson(writer, obj);
            else if (element is Config.Array arr) ToJson(writer, arr);
            else if (element is Config.Primitive pri) ToJson(writer, pri);

            throw new InvalidCastException("element must be either Object, Array or Primitive.");
        }

        private static void ToJson(JsonWriter writer, Config.Object obj)
        {
            writer.WriteStartObject();
            foreach (var (key, value) in obj.Pairs)
            {
                writer.WritePropertyName(key);
                ToJson(writer, value);
            }
            writer.WriteEndObject();
        }

        private static void ToJson(JsonWriter writer, Config.Array arr)
        {
            writer.WriteStartArray();
            foreach (var item in arr)
            {
                ToJson(writer, item);
            }
            writer.WriteEndArray();
        }

        private static void ToJson(JsonWriter writer, Config.Primitive primitive)
        {
            writer.WriteValue(primitive.Value);
        }

        #endregion
    }
}
