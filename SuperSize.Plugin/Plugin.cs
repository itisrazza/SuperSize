using System;

namespace SuperSize.Plugin
{
    /// <summary>
    /// Represents the plugin. When the plugin is installed and initialised,
    /// SuperSize looks for the first class that inherits this class.
    /// <br/>
    /// It's recommended to have only one Plugin class in your assembly.
    /// </summary>
    public abstract class Plugin
    {
        /// <summary>
        /// Plugin's display name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Plugin's author.
        /// </summary>
        public abstract string Author { get; }

    }
}
