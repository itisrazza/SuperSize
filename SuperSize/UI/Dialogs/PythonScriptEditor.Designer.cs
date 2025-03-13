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
            toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            _previewButton = new System.Windows.Forms.ToolStripButton();
            _showHelpButton = new System.Windows.Forms.ToolStripButton();
            _splitContainer = new System.Windows.Forms.SplitContainer();
            textBox1 = new System.Windows.Forms.TextBox();
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
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton5, toolStripSeparator3, toolStripButton3, toolStripSeparator1, toolStripButton1, toolStripButton2, toolStripSeparator2, _previewButton, _showHelpButton });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(624, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.NewScript;
            toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new System.Drawing.Size(84, 22);
            toolStripButton5.Text = "New Script";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.Save;
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new System.Drawing.Size(51, 22);
            toolStripButton3.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.FolderOpenedNoColor;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(63, 22);
            toolStripButton1.Text = "Import";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.ExportScript;
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(60, 22);
            toolStripButton2.Text = "Export";
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
            _previewButton.Click += this.OnPreviewClicked;
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
            _splitContainer.Panel1.Controls.Add(textBox1);
            // 
            // _splitContainer.Panel2
            // 
            _splitContainer.Panel2.Controls.Add(webView21);
            _splitContainer.Size = new System.Drawing.Size(624, 416);
            _splitContainer.SplitterDistance = 344;
            _splitContainer.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(344, 416);
            textBox1.TabIndex = 0;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _showHelpButton;
        private System.Windows.Forms.ToolStripButton _previewButton;
    }
}