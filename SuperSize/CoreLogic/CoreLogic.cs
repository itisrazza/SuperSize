using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using SuperSize.PluginBase;

namespace SuperSize.CoreLogic
{
    public class CoreLogic : Plugin
    {
        public override string DisplayName { get; } = "Built-in Logic";

        public override string Description => "Window size logic included with SuperSize.";

        public override string Author { get; } = "Raresh Nistor";

        public override IEnumerable<Logic> Logic => ImmutableList.Create(new UseAllScreen());
    }
}
