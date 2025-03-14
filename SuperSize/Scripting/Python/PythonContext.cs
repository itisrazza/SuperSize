using Microsoft.Scripting.Hosting;
using System;
using System.Drawing;
using System.Reflection;

namespace SuperSize.Scripting.Python;

public class PythonContext
{
    public ScriptScope Scope { get; }

    public Rectangle? Result { get; private set; }

    public PythonContext()
    {
        Scope = ScriptEngine.CreateScope();
        InitialiseScope();
    }

    public void Execute(string expression)
    {
        ScriptEngine.Execute(expression, Scope);
    }

    public void ExecuteFile(string path)
    {
        ScriptEngine.Execute(path, Scope);
    }

    #region Script Engine

    private static ScriptEngine? _scriptEngine = null;
    private static readonly object _scriptEngineLock = new();

    public static ScriptEngine ScriptEngine
    {
        get
        {
            if (_scriptEngine == null)
            {
                lock (_scriptEngineLock)
                {
                    if (_scriptEngine == null)
                    {
                        _scriptEngine = IronPython.Hosting.Python.CreateEngine();
                        InitialiseEngine(_scriptEngine);
                    }
                }
            }
            return _scriptEngine;
        }
    }

    private static void InitialiseEngine(ScriptEngine engine)
    {
        var runtime = engine.Runtime;

        runtime.LoadAssembly(Assembly.GetExecutingAssembly());
        runtime.LoadAssembly(Assembly.Load("System.Drawing"));
        runtime.LoadAssembly(Assembly.Load("System.Windows.Forms"));
    }

    #endregion

    private void InitialiseScope()
    {
#pragma warning disable CS8974 // Converting method group to non-delegate type
        Scope.SetVariable("screens", PythonHelpers.Screens);
        Scope.SetVariable("point", PythonHelpers.Point);
        Scope.SetVariable("rectangle", PythonHelpers.Rectangle);
        Scope.SetVariable("yield", delegate (Rectangle rectangle)
        {
            Result = rectangle;
        });
#pragma warning restore CS8974
    }

    public static void Thing()
    {
        var engine = IronPython.Hosting.Python.CreateEngine();
        var scope = engine.CreateScope();
    }
}
