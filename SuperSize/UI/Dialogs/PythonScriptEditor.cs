using SuperSize.Model;
using SuperSize.Scripting.Python;
using SuperSize.UI.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperSize.UI.Dialogs;

public partial class PythonScriptEditor : Form
{
    private Settings Settings { get; }

    public PythonScriptEditor(Settings settings)
    {
        Settings = settings;
        InitializeComponent();

        if (settings.TryGetValue("Script", out var script))
        {
            _scriptEditor.Text = script;
        }
    }


    public void OnPreviewClicked(object sender, EventArgs e)
    {
        var context = new PythonContext();
        try
        {
            context.Execute(_scriptEditor.Text);
        }
        catch (Exception ex)
        {
            var dialog = new ScriptErrorDialog(ex);
            dialog.Show();
        }

        if (context.Result is Rectangle result)
        {
            TestForm.Show(result);
        }
    }

    public void OnHelpValueChanged(object sender, EventArgs e)
    {
        _splitContainer.Panel2Collapsed = !_showHelpButton.Checked;
    }

    private void OnSaveClick(object sender, EventArgs e)
    {
        Settings["Script"] = _scriptEditor.Text;
        Settings.Save();
    }
}
