
namespace SuperSize
{
    partial class ConfigForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this._aboutPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.versionLbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.customScriptRadio = new System.Windows.Forms.RadioButton();
            this.builtinScriptChooser = new System.Windows.Forms.ComboBox();
            this.builtinScriptRadio = new System.Windows.Forms.RadioButton();
            this.testButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.keybindPreview = new System.Windows.Forms.Label();
            this.keybindChangeButton = new System.Windows.Forms.Button();
            this.keybindLabel = new System.Windows.Forms.Label();
            this._configPreview = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._aboutPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._configPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // _aboutPage
            // 
            this._aboutPage.Controls.Add(this.groupBox2);
            this._aboutPage.Controls.Add(this.label2);
            this._aboutPage.Controls.Add(this.label1);
            this._aboutPage.Controls.Add(this.pictureBox1);
            this._aboutPage.Controls.Add(this.versionLbl);
            this._aboutPage.Location = new System.Drawing.Point(4, 24);
            this._aboutPage.Name = "_aboutPage";
            this._aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this._aboutPage.Size = new System.Drawing.Size(376, 433);
            this._aboutPage.TabIndex = 1;
            this._aboutPage.Text = "About";
            this._aboutPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(3, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 344);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bella";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "You\'ve been visited by Bella the cat.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SuperSize.Properties.Resources.Bella;
            this.pictureBox2.Location = new System.Drawing.Point(51, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "© 2021 Raresh Nistor and contributors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "SuperSize";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperSize.Properties.Resources.Logo_64;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new System.Drawing.Point(195, 36);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(102, 15);
            this.versionLbl.TabIndex = 2;
            this.versionLbl.Text = "undefined version";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this._aboutPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 461);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.keybindPreview);
            this.tabPage1.Controls.Add(this.keybindChangeButton);
            this.tabPage1.Controls.Add(this.keybindLabel);
            this.tabPage1.Controls.Add(this._configPreview);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.importButton);
            this.groupBox1.Controls.Add(this.customScriptRadio);
            this.groupBox1.Controls.Add(this.builtinScriptChooser);
            this.groupBox1.Controls.Add(this.builtinScriptRadio);
            this.groupBox1.Controls.Add(this.testButton);
            this.groupBox1.Controls.Add(this.previewButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 227);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Window Size";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(47, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter custom Python code here.";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(318, 114);
            this.textBox1.TabIndex = 13;
            this.textBox1.WordWrap = false;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Location = new System.Drawing.Point(289, 78);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 12;
            this.importButton.Text = "&Import...";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // customScriptRadio
            // 
            this.customScriptRadio.AutoSize = true;
            this.customScriptRadio.Location = new System.Drawing.Point(6, 82);
            this.customScriptRadio.Name = "customScriptRadio";
            this.customScriptRadio.Size = new System.Drawing.Size(116, 19);
            this.customScriptRadio.TabIndex = 11;
            this.customScriptRadio.Text = "Use custom code";
            this.customScriptRadio.UseVisualStyleBackColor = true;
            this.customScriptRadio.CheckedChanged += new System.EventHandler(this.customScriptRadio_CheckedChanged);
            // 
            // builtinScriptChooser
            // 
            this.builtinScriptChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.builtinScriptChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.builtinScriptChooser.FormattingEnabled = true;
            this.builtinScriptChooser.Location = new System.Drawing.Point(46, 49);
            this.builtinScriptChooser.Name = "builtinScriptChooser";
            this.builtinScriptChooser.Size = new System.Drawing.Size(318, 23);
            this.builtinScriptChooser.TabIndex = 10;
            // 
            // builtinScriptRadio
            // 
            this.builtinScriptRadio.AutoSize = true;
            this.builtinScriptRadio.Checked = true;
            this.builtinScriptRadio.Location = new System.Drawing.Point(6, 24);
            this.builtinScriptRadio.Name = "builtinScriptRadio";
            this.builtinScriptRadio.Size = new System.Drawing.Size(162, 19);
            this.builtinScriptRadio.TabIndex = 9;
            this.builtinScriptRadio.TabStop = true;
            this.builtinScriptRadio.Text = "Use a built-in window size";
            this.builtinScriptRadio.UseVisualStyleBackColor = true;
            this.builtinScriptRadio.CheckedChanged += new System.EventHandler(this.customScriptRadio_CheckedChanged);
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.Location = new System.Drawing.Point(208, 22);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 8;
            this.testButton.Text = "&Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewButton.Location = new System.Drawing.Point(289, 22);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 3;
            this.previewButton.Text = "&Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // keybindPreview
            // 
            this.keybindPreview.AutoSize = true;
            this.keybindPreview.Location = new System.Drawing.Point(122, 178);
            this.keybindPreview.Name = "keybindPreview";
            this.keybindPreview.Size = new System.Drawing.Size(12, 15);
            this.keybindPreview.TabIndex = 7;
            this.keybindPreview.Text = "-";
            // 
            // keybindChangeButton
            // 
            this.keybindChangeButton.Location = new System.Drawing.Point(293, 174);
            this.keybindChangeButton.Name = "keybindChangeButton";
            this.keybindChangeButton.Size = new System.Drawing.Size(75, 23);
            this.keybindChangeButton.TabIndex = 6;
            this.keybindChangeButton.Text = "&Change...";
            this.keybindChangeButton.UseVisualStyleBackColor = true;
            this.keybindChangeButton.Click += new System.EventHandler(this.keybindChangeButton_Click);
            // 
            // keybindLabel
            // 
            this.keybindLabel.AutoSize = true;
            this.keybindLabel.Location = new System.Drawing.Point(8, 178);
            this.keybindLabel.Name = "keybindLabel";
            this.keybindLabel.Size = new System.Drawing.Size(108, 15);
            this.keybindLabel.TabIndex = 5;
            this.keybindLabel.Text = "Keyboard Shortcut:";
            // 
            // _configPreview
            // 
            this._configPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this._configPreview.Location = new System.Drawing.Point(3, 3);
            this._configPreview.Name = "_configPreview";
            this._configPreview.Size = new System.Drawing.Size(370, 165);
            this._configPreview.TabIndex = 0;
            this._configPreview.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSize Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this._aboutPage.ResumeLayout(false);
            this._aboutPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._configPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage _aboutPage;
        private System.Windows.Forms.PictureBox _configPreview;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Label keybindLabel;
        private System.Windows.Forms.Label keybindPreview;
        private System.Windows.Forms.Button keybindChangeButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.RadioButton customScriptRadio;
        private System.Windows.Forms.ComboBox builtinScriptChooser;
        private System.Windows.Forms.RadioButton builtinScriptRadio;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

