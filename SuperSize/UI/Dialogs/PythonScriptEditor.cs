using SuperSize.Scripting.Python;
using System;
using System.Windows.Forms;

namespace SuperSize.UI.Dialogs;

public partial class PythonScriptEditor : Form
{
    public PythonScriptEditor()
    {
        InitializeComponent();
    }

    public void OnPreviewClicked(object sender, EventArgs e)
    {
        var context = new PythonContext();
        context.Execute(textBox1.Text);
    }

    public void OnHelpValueChanged(object sender, EventArgs e)
    {
        _splitContainer.Panel2Collapsed = !_showHelpButton.Checked;
    }
}
