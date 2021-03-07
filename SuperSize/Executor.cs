using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SuperSize
{
    public class Executor
    {
        private ScriptRuntime _scriptRuntime;
        private ScriptScope _scriptScope;
        private ScriptEngine _scriptEngine;

        private Action<Rectangle> _commitReciever = rect =>
        {
            MessageBox.Show(rect.ToString());
        };

        public Executor(Action<Rectangle> reciever)
        {
            _commitReciever = reciever;

            _scriptRuntime = Python.CreateRuntime();
            _scriptRuntime.LoadAssembly(Assembly.GetExecutingAssembly());
            _scriptRuntime.LoadAssembly(Assembly.Load("System.Drawing"));
            _scriptRuntime.LoadAssembly(Assembly.Load("System.Windows.Forms"));

            _scriptScope = _scriptRuntime.CreateScope();
            ImplementFunctions();

            _scriptEngine = _scriptRuntime.GetEngine("Python");
        }

        private void ImplementFunctions()
        {
            _scriptScope.SetVariable("set_size", _commitReciever);
            _scriptScope.SetVariable("alert", new Action<object>((object message) => { MessageBox.Show(message.ToString()); }));
            
            //
            _scriptScope.SetVariable("get_screens", new Func<Screen[]>(() => Screen.AllScreens));
            _scriptScope.SetVariable("get_all_screen_bounds", new Func<Rectangle>(DisplayUtils.GetAllScreenBounds));

            // object creation
            _scriptScope.SetVariable("rectangle", new Func<int, int, int, int, Rectangle>((x, y, w, h) => new Rectangle(x, y, w, h)));
            _scriptScope.SetVariable("point", new Func<int, int, Point>((x, y) => new Point(x, y)));
        }

        public void Run(string script)
            => _scriptEngine.Execute(script, _scriptScope);

        public void RunFile(string filename)
            => Run(File.ReadAllText(filename));
    }
}
