using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin.Config
{
    public class Array : IElement
    {

        private readonly IList<IElement> _list = new List<IElement>();

        public IList<IElement> GetList() => _list.ToImmutableList();
    }
}
