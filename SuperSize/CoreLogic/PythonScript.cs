using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using SuperSize.Model;
using SuperSize.UI.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.CoreLogic;

[Guid("F491C1AF-3842-4A70-AAD5-F1DCC20F85F7")]
internal sealed class PythonScript : Logic
{
    public override string DisplayName => "Scripting: Python";

    private ScriptRuntime _scriptRuntime;
    private ScriptScope _scriptScope;
    private ScriptEngine _scriptEngine;

    public PythonScript()
    {
        _scriptRuntime = Python.CreateRuntime();
        _scriptScope = _scriptRuntime.CreateScope();
        _scriptEngine = _scriptRuntime.GetEngine("Python");
        PythonSetup();
    }

    public override Task<Rectangle> CalculateWindowSize(Settings settings)
    {
        return Task.FromResult(new Rectangle(0, 0, 0, 0));
    }

    public override void ShowSettings(Settings settings)
    {
        new PythonScriptEditor().ShowDialog();
    }

    private void PythonSetup()
    {
        _scriptRuntime.LoadAssembly(Assembly.GetExecutingAssembly());
        _scriptRuntime.LoadAssembly(Assembly.Load("System.Drawing"));
        _scriptRuntime.LoadAssembly(Assembly.Load("System.Windows.Forms"));

        PopulatePythonScope(new()
        {
            { "alert", new Action<object>(message => MessageBox.Show(message.ToString())) },

            // screen detail
            { "get_screens", new Func<Screen[]>(() => Screen.AllScreens) },
            { "get_all_screen_bounds", new Func<Rectangle>(() => OS.Utilities.GetAllScreenBounds()) },

            // python shorthands .NET object constructors
            { "rectangle", new Func<int, int, int, int, Rectangle>((x, y, w, h) => new Rectangle(x, y, w, h)) },
            { "point", new Func<int, int, Point>((x, y) => new Point(x, y)) },
        });
    }

    private void PopulatePythonScope(Dictionary<string, object?> values)
    {
        foreach (var (key, value) in values)
        {
            _scriptScope.SetVariable(key, value);
        }
    }
}
