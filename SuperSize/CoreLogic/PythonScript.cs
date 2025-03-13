using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using SuperSize.Model;
using SuperSize.Scripting.Python;
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

    public override Task<Rectangle> CalculateWindowSize(Settings settings) => Task.Run(() =>
        {
            if (!settings.TryGetValue("Script", out var script))
            {
                MessageBox.Show(
                    "There is no script loaded. Please create or import a script.",
                    "SuperSize - Missing Python Script", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("TODO: No script loaded. Better exception pls");
            }

            var context = new PythonContext();
            context.Execute(script!);

            if (context.Result is Rectangle result)
            {
                return result;

            }

            MessageBox.Show(
                "The script did not yield a result. Please check the script.",
                "SuperSize - No Yield",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("TODO: Script didn't yield(). Better exception pls");
        });

    public override void ShowSettings(Settings settings)
    {
        new PythonScriptEditor().ShowDialog();
    }
}
