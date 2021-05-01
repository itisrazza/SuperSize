using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Service
{

    [Serializable]
    public class PluginFailureException : Exception
    {
        public string? PluginPath { get; protected set; }

        public PluginFailureException(string message) : base(message) { }

        public PluginFailureException(string path, string message) : base(message)
        {
            PluginPath = path;
        }

        public PluginFailureException(string message, Exception inner) : base(message, inner) { }

        public PluginFailureException(string path, string message, Exception inner) : base(message, inner)
        {
            PluginPath = path;
        }

        public override string ToString()
        {
            return $"Failed to load '{PluginPath}'.\n{base.ToString()}";
        }
    }
}
