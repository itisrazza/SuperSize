
namespace SuperSize.Forms
{
    partial class KeyboardShortcutDialog
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
            this.controlCheckbox = new System.Windows.Forms.CheckBox();
            this.windowsCheckbox = new System.Windows.Forms.CheckBox();
            this.shiftCheckbox = new System.Windows.Forms.CheckBox();
            this.altCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlCheckbox
            // 
            this.controlCheckbox.AutoSize = true;
            this.controlCheckbox.Location = new System.Drawing.Point(62, 22);
            this.controlCheckbox.Name = "controlCheckbox";
            this.controlCheckbox.Size = new System.Drawing.Size(66, 19);
            this.controlCheckbox.TabIndex = 0;
            this.controlCheckbox.Text = "Control";
            this.controlCheckbox.UseVisualStyleBackColor = true;
            // 
            // windowsCheckbox
            // 
            this.windowsCheckbox.AutoSize = true;
            this.windowsCheckbox.Location = new System.Drawing.Point(134, 22);
            this.windowsCheckbox.Name = "windowsCheckbox";
            this.windowsCheckbox.Size = new System.Drawing.Size(75, 19);
            this.windowsCheckbox.TabIndex = 1;
            this.windowsCheckbox.Text = "Windows";
            this.windowsCheckbox.UseVisualStyleBackColor = true;
            // 
            // shiftCheckbox
            // 
            this.shiftCheckbox.AutoSize = true;
            this.shiftCheckbox.Location = new System.Drawing.Point(6, 22);
            this.shiftCheckbox.Name = "shiftCheckbox";
            this.shiftCheckbox.Size = new System.Drawing.Size(50, 19);
            this.shiftCheckbox.TabIndex = 2;
            this.shiftCheckbox.Text = "Shift";
            this.shiftCheckbox.UseVisualStyleBackColor = true;
            // 
            // altCheckbox
            // 
            this.altCheckbox.AutoSize = true;
            this.altCheckbox.Location = new System.Drawing.Point(215, 22);
            this.altCheckbox.Name = "altCheckbox";
            this.altCheckbox.Size = new System.Drawing.Size(41, 19);
            this.altCheckbox.TabIndex = 3;
            this.altCheckbox.Text = "&Alt";
            this.altCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.shiftCheckbox);
            this.groupBox1.Controls.Add(this.altCheckbox);
            this.groupBox1.Controls.Add(this.controlCheckbox);
            this.groupBox1.Controls.Add(this.windowsCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifiers";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keys";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(264, 165);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(183, 165);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // KeyboardShortcutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 200);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyboardShortcutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keyboard Shortcut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox controlCheckbox;
        private System.Windows.Forms.CheckBox windowsCheckbox;
        private System.Windows.Forms.CheckBox shiftCheckbox;
        private System.Windows.Forms.CheckBox altCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}