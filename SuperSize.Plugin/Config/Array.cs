using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SuperSize.Plugin.Config
{
    /// <summary>
    /// An array containing a list of <see cref="IElement"/>.
    /// </summary>
    [Serializable]
    public class Array : IElement, IList<IElement>
    {

        private readonly IList<IElement> _list = new List<IElement>();

        public IElement this[int index] { get => _list[index]; set => _list[index] = value; }

        public int Count => _list.Count;

        public bool IsReadOnly => _list.IsReadOnly;

        public void Add(IElement item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(IElement item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(IElement[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IElement> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public int IndexOf(IElement item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, IElement item)
        {
            _list.Insert(index, item);
        }

        public bool Remove(IElement item)
        {
            return _list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
