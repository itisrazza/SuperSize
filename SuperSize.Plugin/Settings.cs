using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin
{
    public abstract class Settings : IDictionary<string, string>
    {
        public abstract ICollection<string> Keys { get; }

        public abstract ICollection<string> Values { get; }

        public abstract int Count { get; }

        public abstract bool IsReadOnly { get; }

        public abstract string this[string key] { get; set; }

        /// <summary>
        /// Retrieves a read-only of the settings for another logic.
        /// <para />
        /// Logics should have their GUID set manually, otherwise they may change between versions.
        /// </summary>
        /// <param name="logic"></param>
        /// <returns>Settings for another logic.</returns>
        public abstract Settings GetLogicSettings(Guid logic);

        /// <summary>
        /// Get a read-only copy of these settings.
        /// </summary>
        public abstract Settings GetReadOnly();

        /// <summary>
        /// Save these settings.
        /// </summary>
        public abstract void Save();

        /// <summary>
        /// Reload these settings. Changes made will be discarded.
        /// </summary>
        public abstract void Reload();

        public abstract void Add(string key, string value);

        public abstract bool ContainsKey(string key);

        public abstract bool Remove(string key);

        public abstract bool TryGetValue(string key, [MaybeNullWhen(false)] out string value);

        public abstract void Add(KeyValuePair<string, string> item);

        public abstract void Clear();

        public abstract bool Contains(KeyValuePair<string, string> item);

        public abstract void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex);

        public abstract bool Remove(KeyValuePair<string, string> item);

        public abstract IEnumerator<KeyValuePair<string, string>> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
