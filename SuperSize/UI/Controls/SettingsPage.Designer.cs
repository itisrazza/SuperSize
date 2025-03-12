
namespace SuperSize.UI.Controls
{
    partial class SettingsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            previewBox = new System.Windows.Forms.PictureBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            _logicComboBox = new System.Windows.Forms.ComboBox();
            keybindLabel = new System.Windows.Forms.Label();
            keybindPreviewLbl = new System.Windows.Forms.Label();
            keybindChangeBtn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            testBtn = new System.Windows.Forms.Button();
            settingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)previewBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // previewBox
            // 
            previewBox.Dock = System.Windows.Forms.DockStyle.Top;
            previewBox.Location = new System.Drawing.Point(0, 0);
            previewBox.Name = "previewBox";
            previewBox.Size = new System.Drawing.Size(370, 165);
            previewBox.TabIndex = 0;
            previewBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(_logicComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(keybindLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(keybindPreviewLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(keybindChangeBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 165);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            tableLayoutPanel1.Size = new System.Drawing.Size(370, 268);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // _logicComboBox
            // 
            tableLayoutPanel1.SetColumnSpan(_logicComboBox, 2);
            _logicComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            _logicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _logicComboBox.FormattingEnabled = true;
            _logicComboBox.IntegralHeight = false;
            _logicComboBox.Location = new System.Drawing.Point(119, 32);
            _logicComboBox.Name = "_logicComboBox";
            _logicComboBox.Size = new System.Drawing.Size(248, 23);
            _logicComboBox.TabIndex = 0;
            _logicComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // keybindLabel
            // 
            keybindLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            keybindLabel.Location = new System.Drawing.Point(3, 0);
            keybindLabel.Name = "keybindLabel";
            keybindLabel.Size = new System.Drawing.Size(110, 29);
            keybindLabel.TabIndex = 1;
            keybindLabel.Text = "Keyboard Shortcut:";
            keybindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keybindPreviewLbl
            // 
            keybindPreviewLbl.AutoEllipsis = true;
            keybindPreviewLbl.AutoSize = true;
            keybindPreviewLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            keybindPreviewLbl.Location = new System.Drawing.Point(119, 0);
            keybindPreviewLbl.Name = "keybindPreviewLbl";
            keybindPreviewLbl.Size = new System.Drawing.Size(167, 29);
            keybindPreviewLbl.TabIndex = 2;
            keybindPreviewLbl.Text = "Modifier + Keys";
            keybindPreviewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keybindChangeBtn
            // 
            keybindChangeBtn.Location = new System.Drawing.Point(292, 3);
            keybindChangeBtn.Name = "keybindChangeBtn";
            keybindChangeBtn.Size = new System.Drawing.Size(75, 23);
            keybindChangeBtn.TabIndex = 3;
            keybindChangeBtn.Text = "&Change...";
            keybindChangeBtn.UseVisualStyleBackColor = true;
            keybindChangeBtn.Click += keybindChangeBtn_Click;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 29);
            label3.TabIndex = 4;
            label3.Text = "Logic:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(testBtn);
            flowLayoutPanel1.Controls.Add(settingsBtn);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(116, 58);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(254, 70);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // testBtn
            // 
            testBtn.Location = new System.Drawing.Point(176, 3);
            testBtn.Name = "testBtn";
            testBtn.Size = new System.Drawing.Size(75, 23);
            testBtn.TabIndex = 1;
            testBtn.Text = "&Test";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.Location = new System.Drawing.Point(95, 3);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new System.Drawing.Size(75, 23);
            settingsBtn.TabIndex = 2;
            settingsBtn.Text = "&Settings...";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click_1;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(previewBox);
            Name = "SettingsPage";
            Size = new System.Drawing.Size(370, 433);
            Load += SettingsPage_Load;
            Enter += SettingsPage_Enter;
            ((System.ComponentModel.ISupportInitialize)previewBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox _logicComboBox;
        private System.Windows.Forms.Label keybindLabel;
        private System.Windows.Forms.Label keybindPreviewLbl;
        private System.Windows.Forms.Button keybindChangeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button settingsBtn;
    }
}
