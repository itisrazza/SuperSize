using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using SuperSize.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Screen = SuperSize.Model.Screen;

namespace SuperSize.Service
{
    public class PythonSizingLogic : SizingLogic
    {
        private ScriptRuntime _scriptRuntime;
        private ScriptScope _scriptScope;
        private ScriptEngine _scriptEngine;

        /// <summary>
        /// The code being run for this sizing setup.
        /// </summary>
        public string Code { get; }

        private PythonSizingLogic(string source)
        {
            Code = source;

            // python setup
            _scriptRuntime = Python.CreateRuntime();
            _scriptScope = _scriptRuntime.CreateScope();
            _scriptEngine = _scriptRuntime.GetEngine("Python");
            PythonSetup();
        }

        public static PythonSizingLogic FromSource(string source)
        {
            return new PythonSizingLogic(source);
        }

        public static PythonSizingLogic FromFile(string file)
        {
            return new PythonSizingLogic(File.ReadAllText(file));
        }

        public override Rectangle Calculate(Screen[] screens)
        {
            var result = (Rectangle?)null;

            // function for setting the result
            var commitAction = new Action<Rectangle>(rect => result = rect);
            _scriptScope.SetVariable("set_size", commitAction);

            // execute script
            _scriptEngine.Execute(Code, _scriptScope);

            // return the result
            if (result == null) throw new NullReferenceException("Script did not set the rectangle value.");
            return result.Value;
        }

        private void PythonSetup()
        {
            // create runtime and load relevant .NET assemblies
            _scriptRuntime.LoadAssembly(Assembly.GetExecutingAssembly());
            _scriptRuntime.LoadAssembly(Assembly.Load("System.Drawing"));
            _scriptRuntime.LoadAssembly(Assembly.Load("System.Windows.Forms"));

            // create scope and populate it
            PopulateScope(new()
            {
                { "alert", new Action<object>(message => MessageBox.Show(message.ToString())) },

                // screen detail
                { "get_screens", new Func<Screen[]>(() => Screen.GetAllScreens()) },
                { "get_all_screen_bounds", new Func<Rectangle>(() => DisplayUtils.GetAllScreenBounds()) },

                // .NET object constructors
                { "rectange", new Func<int, int, int, int, Rectangle>((x, y, w, h) => new Rectangle(x, y, w, h)) },
                { "point", new Func<int, int, Point>((x, y) => new Point(x, y)) },
            });

            // lastly the engine
        }

        private void PopulateScope(Dictionary<string, object?> values)
        {
            foreach (var (key, value) in values)
            {
                _scriptScope.SetVariable(key, value);
            }
        }
    }
}
