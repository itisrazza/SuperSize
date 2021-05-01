using SuperSize.Plugin;
using System;
using System.Collections.Generic;

namespace SuperSize.Logic
{
    public class Plugin : PluginBase
    {
        public override string Name { get; } = "SuperSize Built-in Logic";

        public override string Author { get; } = "Raresh Nistor";

        public override IEnumerable<SuperSize.Plugin.Logic> AvailableLogic => new List<SuperSize.Plugin.Logic>
        {
            new SwallowLogic()
        };
    }
}
