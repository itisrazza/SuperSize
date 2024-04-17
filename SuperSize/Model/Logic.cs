using SuperSize.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Model;

/// <summary>
/// Represents a "sizing logic" (needs a new name, this is what I've been stuck with from the beginning).
/// </summary>
public abstract class Logic
{
    public abstract string DisplayName { get; }

    public virtual Dictionary<string, string> InitialSettings { get; } = new();

    public abstract Task<Rectangle> CalculateWindowSize(Settings settings);

    public virtual void ShowSettings(Settings settings) => throw new NotImplementedException();

    public override string ToString()
    {
        return DisplayName;
    }
}
