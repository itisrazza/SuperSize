using SuperSize.Plugin;
using System;
using System.Collections.Generic;

namespace SuperSize.CoreLogic
{
    public class Plugin : PluginBase
    {
        public override string Name { get; } = "Built-in Logic";

        public override string Author { get; } = "Raresh Nistor";

        public override IEnumerable<LogicBase> AvailableLogic { get; } = new List<LogicBase> {
            new UseAllScreen(),
        };
    }
}
