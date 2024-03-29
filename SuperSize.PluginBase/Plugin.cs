﻿using System.Collections.Generic;

namespace SuperSize.PluginBase
{
    public abstract class Plugin
    {
        /// <summary>
        /// Plugin's display name.
        /// </summary>
        public abstract string DisplayName { get; }

        public abstract string? Description { get; }

        /// <summary>
        /// Plugin's author.
        /// </summary>
        public abstract string Author { get; }

        /// <summary>
        /// Plugin's available logic.
        /// </summary>
        public abstract IEnumerable<Logic> Logic { get; }
    }
}
