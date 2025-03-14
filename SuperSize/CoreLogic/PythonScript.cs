using SuperSize.Model;
using SuperSize.Scripting.Python;
using SuperSize.UI.Dialogs;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.CoreLogic;

[Guid("F491C1AF-3842-4A70-AAD5-F1DCC20F85F7")]
internal sealed class PythonScript : Logic
{
    public override string DisplayName => "Scripting: Python";

    public override Task<LogicResult> CalculateWindowSize(Settings settings) => Task.Run(() =>
        {
            if (!settings.TryGetValue("Script", out var script))
            {
                return LogicResult.NoResult("No script loaded");
            }

            var context = new PythonContext();
            context.Execute(script!);

            if (context.Result is Rectangle result)
            {
                return LogicResult.OK(result);
            }

            return LogicResult.NoResult("Script didn't yield");
        });

    public override void ShowSettings(Settings settings)
    {
        using var dialog = new PythonScriptEditor(settings);
        dialog.ShowDialog();
    }
}
