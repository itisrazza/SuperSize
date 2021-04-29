using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin.Config
{
    public class Object : IDictionary<string, IElement>
    {

        private Dictionary<string, IElement> _dict = new();

        public IElement this[string key] { get => ((IDictionary<string, IElement>)_dict)[key]; set => ((IDictionary<string, IElement>)_dict)[key] = value; }

        public ICollection<string> Keys => ((IDictionary<string, IElement>)_dict).Keys;

        public ICollection<IElement> Values => ((IDictionary<string, IElement>)_dict).Values;

        public int Count => ((ICollection<KeyValuePair<string, IElement>>)_dict).Count;

        public bool IsReadOnly => ((ICollection<KeyValuePair<string, IElement>>)_dict).IsReadOnly;

        public void Add(string key, IElement value)
        {
            ((IDictionary<string, IElement>)_dict).Add(key, value);
        }

        public void Add(KeyValuePair<string, IElement> item)
        {
            ((ICollection<KeyValuePair<string, IElement>>)_dict).Add(item);
        }

        public void Clear()
        {
            ((ICollection<KeyValuePair<string, IElement>>)_dict).Clear();
        }

        public bool Contains(KeyValuePair<string, IElement> item)
        {
            return ((ICollection<KeyValuePair<string, IElement>>)_dict).Contains(item);
        }

        public bool ContainsKey(string key)
        {
            return ((IDictionary<string, IElement>)_dict).ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<string, IElement>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<string, IElement>>)_dict).CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<string, IElement>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, IElement>>)_dict).GetEnumerator();
        }

        public bool Remove(string key)
        {
            return ((IDictionary<string, IElement>)_dict).Remove(key);
        }

        public bool Remove(KeyValuePair<string, IElement> item)
        {
            return ((ICollection<KeyValuePair<string, IElement>>)_dict).Remove(item);
        }

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out IElement value)
        {
            return ((IDictionary<string, IElement>)_dict).TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_dict).GetEnumerator();
        }
    }
}
