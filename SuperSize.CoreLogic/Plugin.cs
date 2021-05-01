using SuperSize.Plugin;
using System;
using System.Collections.Generic;

namespace SuperSize.CoreLogic
{
    public class Plugin : PluginBase
    {
        public override string Name => throw new NotImplementedException();

        public override string Author => throw new NotImplementedException();

        public override IEnumerable<LogicBase> AvailableLogic { get; } = new List<LogicBase> {
            new ExtendBeyondSpaceLogic(),
        };
    }
}
