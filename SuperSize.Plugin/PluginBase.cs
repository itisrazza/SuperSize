using System;
using System.Collections.Generic;
using System.Reflection;

namespace SuperSize.Plugin
{
    /// <summary>
    /// Represents the plugin. When the plugin is installed and initialised,
    /// SuperSize looks for the first class that inherits this class.
    /// <br/>
    /// It's recommended to have only one Plugin class in your assembly.
    /// </summary>
    public abstract class PluginBase
    {
        /// <summary>
        /// Plugin's display name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Plugin's author.
        /// </summary>
        public abstract string Author { get; }

        /// <summary>
        /// Plugin's available logic.
        /// </summary>
        public virtual IEnumerable<LogicBase> AvailableLogic { get; } = new List<LogicBase>();

        /// <summary>
        /// Automatically discover the logic in an assembly.
        /// </summary>
        /// <param name="assembly">Assembly to discover logic in.</param>
        /// <returns></returns>
        public static IEnumerable<LogicBase> DiscoverLogic(Assembly assembly)
        {
            // TODO: make big brain code to automatically discover logic
            // extending the Logic class with a constructor taking 0 arguments.
            throw new NotImplementedException();
        }
    }
}
