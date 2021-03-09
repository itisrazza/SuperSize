
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
            System.Windows.Forms.TabPage _aboutPage;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.testButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.keybindPreview = new System.Windows.Forms.Label();
            this.keybindChangeButton = new System.Windows.Forms.Button();
            this.keybindLabel = new System.Windows.Forms.Label();
            this._configPreview = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            _aboutPage = new System.Windows.Forms.TabPage();
            _aboutPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._configPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // _aboutPage
            // 
            _aboutPage.Controls.Add(this.label1);
            _aboutPage.Location = new System.Drawing.Point(4, 24);
            _aboutPage.Name = "_aboutPage";
            _aboutPage.Padding = new System.Windows.Forms.Padding(3);
            _aboutPage.Size = new System.Drawing.Size(376, 433);
            _aboutPage.TabIndex = 1;
            _aboutPage.Text = "About";
            _aboutPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(_aboutPage);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
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
            this.textBox1.Size = new System.Drawing.Size(318, 114);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(289, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Import...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Use custom code";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(162, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Use a built-in window size";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this._configPreview.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "SuperSize 0.1\r\nmade with the power of kittens\r\n";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "SuperSize Settings";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            _aboutPage.ResumeLayout(false);
            _aboutPage.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}

