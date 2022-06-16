using SuperSize.PluginBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SuperSize.Service
{
    public class SettingsService
    {
        private static Dictionary<Guid, Dictionary<string, string>> _logicConfig = new();

        /// <summary>
        /// Get the config provider for the plugins.
        /// </summary>
        public static Settings GetSettings(Guid logicGuid, bool readOnly = false)
        {
            if (!_logicConfig.ContainsKey(logicGuid))
            {
                _logicConfig[logicGuid] = new();
            }

            return new SettingsImpl(new(_logicConfig[logicGuid]), logicGuid);
        }

        public static Settings GetSettings(Logic logic, bool readOnly = false)
        {
            return GetSettings(logic.GetType().GUID);
        }

        public static void Save()
        {
            var sw = new StringWriter();
            using var jw = new JsonTextWriter(sw);

            jw.WriteStartObject();
            foreach (var (guid, config) in _logicConfig)
            {
                jw.WritePropertyName(guid.ToString());
                jw.WriteStartObject();
                foreach (var (key, value) in config)
                {
                    jw.WritePropertyName(key);
                    jw.WriteValue(value);
                }
                jw.WriteEndObject();
            }
            jw.WriteEndObject();

            var settings = Properties.Settings.Default;
            settings.LogicSettings = sw.ToString();
            settings.Save();
        }

        public static void Load()
        {
            var doc = JsonDocument.Parse(Properties.Settings.Default.LogicSettings);
            _logicConfig = doc.RootElement.EnumerateObject()
                .Select(obj => (Guid.Parse(obj.Name), obj.Value.EnumerateObject()
                    .Select(obj => (obj.Name, obj.Value.GetString()!))
                    .ToDictionary(tuple => tuple.Name, tuple => tuple.Item2)))
                .ToDictionary(tuple => tuple.Item1, tuple => tuple.Item2);
        }

        private class SettingsImpl : Settings
        {
            private Dictionary<string, string> _data;

            public Guid LogicGuid { get; }

            public SettingsImpl(Dictionary<string, string> data, Guid guid)
            {
                _data = data ?? new Dictionary<string, string>();
                LogicGuid = guid;
            }

            public override Settings GetLogicSettings(Guid logic) => GetSettings(logic);

            public override void Save()
            {
                _logicConfig[LogicGuid] = new(_data);
            }

            public override void Reload()
            {
                _data = new(_logicConfig[LogicGuid]);
            }

            #region Implement 'Settings' through '_data'

            public override string this[string key]
            {
                get => _data[key];
                set
                {
                    if (IsReadOnly) throw new NotSupportedException();
                    _data[key] = value;
                }
            }

            public override ICollection<string> Keys => _data.Keys;
            public override ICollection<string> Values => _data.Values;
            public override int Count => _data.Count;
            public override bool IsReadOnly => ((ICollection<KeyValuePair<string, string>>)_data).IsReadOnly;
            public override void Add(string key, string value) => _data.Add(key, value);
            public override void Add(KeyValuePair<string, string> item) => _data.Add(item.Key, item.Value);
            public override void Clear() => _data.Clear();
            public override bool Contains(KeyValuePair<string, string> item) => _data.Contains(item);
            public override bool ContainsKey(string key) => _data.ContainsKey(key);
            public override void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => ((ICollection<KeyValuePair<string, string>>)_data).CopyTo(array, arrayIndex);
            public override IEnumerator<KeyValuePair<string, string>> GetEnumerator() => _data.GetEnumerator();
            public override bool Remove(string key) => _data.Remove(key);
            public override bool Remove(KeyValuePair<string, string> item) => ((ICollection<KeyValuePair<string, string>>)_data).Remove(item);
            public override bool TryGetValue(string key, [MaybeNullWhen(false)] out string value) => _data.TryGetValue(key, out value);

            #endregion
        }
    }
}
