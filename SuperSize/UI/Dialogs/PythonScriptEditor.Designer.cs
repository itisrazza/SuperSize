namespace SuperSize.UI.Dialogs
{
    partial class PythonScriptEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PythonScriptEditor));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            _newScriptButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            _saveButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            _importButton = new System.Windows.Forms.ToolStripButton();
            _exportButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            _previewButton = new System.Windows.Forms.ToolStripButton();
            _showHelpButton = new System.Windows.Forms.ToolStripButton();
            _splitContainer = new System.Windows.Forms.SplitContainer();
            _scriptEditor = new System.Windows.Forms.TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_splitContainer).BeginInit();
            _splitContainer.Panel1.SuspendLayout();
            _splitContainer.Panel2.SuspendLayout();
            _splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { _newScriptButton, toolStripSeparator3, _saveButton, toolStripSeparator1, _importButton, _exportButton, toolStripSeparator2, _previewButton, _showHelpButton });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(624, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // _newScriptButton
            // 
            _newScriptButton.Image = Properties.Resources.NewScript;
            _newScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _newScriptButton.Name = "_newScriptButton";
            _newScriptButton.Size = new System.Drawing.Size(84, 22);
            _newScriptButton.Text = "New Script";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // _saveButton
            // 
            _saveButton.Image = Properties.Resources.Save;
            _saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _saveButton.Name = "_saveButton";
            _saveButton.Size = new System.Drawing.Size(51, 22);
            _saveButton.Text = "Save";
            _saveButton.Click += OnSaveClick;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _importButton
            // 
            _importButton.Image = Properties.Resources.FolderOpenedNoColor;
            _importButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _importButton.Name = "_importButton";
            _importButton.Size = new System.Drawing.Size(63, 22);
            _importButton.Text = "Import";
            // 
            // _exportButton
            // 
            _exportButton.Image = Properties.Resources.ExportScript;
            _exportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _exportButton.Name = "_exportButton";
            _exportButton.Size = new System.Drawing.Size(60, 22);
            _exportButton.Text = "Export";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _previewButton
            // 
            _previewButton.Image = Properties.Resources.Play;
            _previewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _previewButton.Name = "_previewButton";
            _previewButton.Size = new System.Drawing.Size(68, 22);
            _previewButton.Text = "Preview";
            _previewButton.Click += OnPreviewClicked;
            // 
            // _showHelpButton
            // 
            _showHelpButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            _showHelpButton.Checked = true;
            _showHelpButton.CheckOnClick = true;
            _showHelpButton.CheckState = System.Windows.Forms.CheckState.Checked;
            _showHelpButton.Image = Properties.Resources.StatusHelp_18_18;
            _showHelpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _showHelpButton.Name = "_showHelpButton";
            _showHelpButton.Size = new System.Drawing.Size(84, 22);
            _showHelpButton.Text = "Show Help";
            _showHelpButton.CheckStateChanged += OnHelpValueChanged;
            // 
            // _splitContainer
            // 
            _splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            _splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            _splitContainer.Location = new System.Drawing.Point(0, 25);
            _splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            _splitContainer.Panel1.Controls.Add(_scriptEditor);
            // 
            // _splitContainer.Panel2
            // 
            _splitContainer.Panel2.Controls.Add(webView21);
            _splitContainer.Size = new System.Drawing.Size(624, 416);
            _splitContainer.SplitterDistance = 344;
            _splitContainer.TabIndex = 1;
            // 
            // _scriptEditor
            // 
            _scriptEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            _scriptEditor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            _scriptEditor.Location = new System.Drawing.Point(0, 0);
            _scriptEditor.Multiline = true;
            _scriptEditor.Name = "_scriptEditor";
            _scriptEditor.Size = new System.Drawing.Size(344, 416);
            _scriptEditor.TabIndex = 0;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            webView21.Location = new System.Drawing.Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new System.Drawing.Size(276, 416);
            webView21.Source = new System.Uri("https://www.youtube.com/watch?v=ZHgyQGoeaB0", System.UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // PythonScriptEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 441);
            Controls.Add(_splitContainer);
            Controls.Add(toolStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "PythonScriptEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Python Script Editor - SuperSize";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            _splitContainer.Panel1.ResumeLayout(false);
            _splitContainer.Panel1.PerformLayout();
            _splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_splitContainer).EndInit();
            _splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.ToolStripButton _importButton;
        private System.Windows.Forms.ToolStripButton _exportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox _scriptEditor;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ToolStripButton _newScriptButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _showHelpButton;
        private System.Windows.Forms.ToolStripButton _previewButton;
    }
}