using Microsoft.Web.WebView2.Core;
using SuperSize.Model;
using SuperSize.Scripting.Python;
using SuperSize.UI.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SuperSize.UI.Dialogs;

public partial class PythonScriptEditor : Form
{
    private string BaseTitle;

    private Settings Settings { get; }

    public PythonScriptEditor(Settings settings)
    {
        Settings = settings;
        InitializeComponent();

        BaseTitle = Text;

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
            TestForm.ShowDialog(result, this);
        }
    }

    public void OnHelpValueChanged(object sender, EventArgs e)
    {
        _splitContainer.Panel2Collapsed = !_showHelpButton.Checked;
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        SaveScript();
    }

    private void SaveScript()
    {
        Settings["Script"] = _scriptEditor.Text;
        Settings.Save();

        UpdateTitle();
    }

    private void OnImportClicked(object sender, EventArgs e)
    {
        if (!ExportCurrentScript()) return;

        var result = _openFileDialog.ShowDialog();
        if (result != DialogResult.OK) return;

        try
        {
            _scriptEditor.Text = File.ReadAllText(_openFileDialog.FileName, Encoding.UTF8);
            SaveScript();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Import script: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private bool ExportCurrentScript()
    {
        if (!PromptToSaveIfDirty()) return false;

        if (Settings["Script"].Trim().Length == 0) return true;

        var result = MessageBox.Show(
            this,
            "This will overwrite the currently loaded script. Would you like to export the currently saved script first?",
            "Import script",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );
        if (result == DialogResult.Cancel) return false;
        if (result == DialogResult.No) return true;

        //

        result = _saveFileDialog.ShowDialog();
        if (result != DialogResult.OK) return false;

        try
        {
            File.WriteAllText(_saveFileDialog.FileName, Settings["Script"], Encoding.UTF8);
        }
        catch (Exception e)
        {
            MessageBox.Show(this, e.Message, "Import script: Error while exporting saved script", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void OnExportClicked(object sender, EventArgs e)
    {
        if (!PromptToSaveIfDirty()) return;

        var result = _saveFileDialog.ShowDialog();
        if (result != DialogResult.OK) return;

        try
        {
            File.WriteAllText(_saveFileDialog.FileName, Settings["Script"], Encoding.UTF8);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Import script: Error while exporting saved script", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool PromptToSaveIfDirty(string? title = null)
    {
        if (!IsEditorDirty()) return true;

        var result = MessageBox.Show(this,
            "There are unsaved changes. Would you like to save them?",
            title ?? "Unsaved changes",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        );
        if (result == DialogResult.Cancel) return false;
        if (result == DialogResult.No) return true;

        SaveScript();
        return true;
    }

    private bool IsEditorDirty()
    {
        return _scriptEditor.Text != Settings["Script"];
    }

    private void OnWebViewInitialised(object sender, CoreWebView2InitializationCompletedEventArgs e)
    {
        _helpViewer.CoreWebView2.NewWindowRequested += OnWebViewNewWindowRequested;
    }

    private void OnWebViewNewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
    {
        e.Handled = true;
        _ = Windows.System.Launcher.LaunchUriAsync(new Uri(e.Uri));
    }

    private void OnFormClosing(object sender, FormClosingEventArgs e)
    {
        if (!PromptToSaveIfDirty())
        {
            e.Cancel = true;
            return;
        }
    }

    private void OnNewScriptClicked(object sender, EventArgs e)
    {
        if (!ExportCurrentScript()) return;

        _scriptEditor.Text = Encoding.UTF8.GetString(Properties.Resources.PythonSample);
        SaveScript();
    }

    private void OnScriptEditorTextChange(object sender, EventArgs e)
    {
        UpdateTitle();
    }

    private void UpdateTitle()
    {
        Text = BaseTitle + (IsEditorDirty() ? " (unsaved)" : "");
    }
}
