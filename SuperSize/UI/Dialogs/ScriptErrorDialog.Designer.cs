namespace SuperSize.UI.Dialogs
{
    partial class ScriptErrorDialog
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            _layout = new System.Windows.Forms.TableLayoutPanel();
            _header = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            _exceptionMessage = new System.Windows.Forms.Label();
            _exceptionDetails = new System.Windows.Forms.TextBox();
            _footer = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            _okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            _layout.SuspendLayout();
            _header.SuspendLayout();
            _footer.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Script1;
            pictureBox1.Location = new System.Drawing.Point(8, 9);
            pictureBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pictureBox1.Name = "pictureBox1";
            _header.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new System.Drawing.Size(32, 32);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // _layout
            // 
            _layout.ColumnCount = 1;
            _layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _layout.Controls.Add(_header, 0, 0);
            _layout.Controls.Add(_exceptionDetails, 0, 1);
            _layout.Controls.Add(_footer, 0, 2);
            _layout.Dock = System.Windows.Forms.DockStyle.Fill;
            _layout.Location = new System.Drawing.Point(0, 0);
            _layout.Name = "_layout";
            _layout.RowCount = 3;
            _layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _layout.Size = new System.Drawing.Size(484, 293);
            _layout.TabIndex = 1;
            // 
            // _header
            // 
            _header.AutoSize = true;
            _header.ColumnCount = 2;
            _header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            _header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _header.Controls.Add(pictureBox1, 0, 0);
            _header.Controls.Add(label1, 1, 0);
            _header.Controls.Add(_exceptionMessage, 1, 1);
            _header.Dock = System.Windows.Forms.DockStyle.Fill;
            _header.Location = new System.Drawing.Point(3, 3);
            _header.Name = "_header";
            _header.RowCount = 3;
            _header.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _header.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _header.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _header.Size = new System.Drawing.Size(478, 52);
            _header.TabIndex = 0;
            _header.Paint += tableLayoutPanel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.DarkRed;
            label1.Location = new System.Drawing.Point(52, 4);
            label1.Margin = new System.Windows.Forms.Padding(4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(422, 20);
            label1.TabIndex = 0;
            label1.Text = "An error occured while executing the script";
            // 
            // _exceptionMessage
            // 
            _exceptionMessage.AutoSize = true;
            _exceptionMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            _exceptionMessage.Location = new System.Drawing.Point(52, 32);
            _exceptionMessage.Margin = new System.Windows.Forms.Padding(4);
            _exceptionMessage.Name = "_exceptionMessage";
            _exceptionMessage.Size = new System.Drawing.Size(422, 16);
            _exceptionMessage.TabIndex = 1;
            _exceptionMessage.Text = "Exception Type: Exception Message";
            // 
            // _exceptionDetails
            // 
            _exceptionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            _exceptionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            _exceptionDetails.Location = new System.Drawing.Point(3, 61);
            _exceptionDetails.Multiline = true;
            _exceptionDetails.Name = "_exceptionDetails";
            _exceptionDetails.ReadOnly = true;
            _exceptionDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            _exceptionDetails.Size = new System.Drawing.Size(478, 191);
            _exceptionDetails.TabIndex = 1;
            // 
            // _footer
            // 
            _footer.AutoSize = true;
            _footer.ColumnCount = 3;
            _footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            _footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            _footer.Controls.Add(button1, 1, 0);
            _footer.Controls.Add(_okButton, 2, 0);
            _footer.Dock = System.Windows.Forms.DockStyle.Fill;
            _footer.Location = new System.Drawing.Point(3, 258);
            _footer.Name = "_footer";
            _footer.RowCount = 1;
            _footer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _footer.Size = new System.Drawing.Size(478, 32);
            _footer.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new System.Drawing.Point(268, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(126, 26);
            button1.TabIndex = 0;
            button1.Text = "Copy to &Clipboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            _okButton.AutoSize = true;
            _okButton.Location = new System.Drawing.Point(400, 3);
            _okButton.Name = "_okButton";
            _okButton.Size = new System.Drawing.Size(75, 26);
            _okButton.TabIndex = 1;
            _okButton.Text = "OK";
            _okButton.UseVisualStyleBackColor = true;
            _okButton.Click += OnOkClicked;
            // 
            // ScriptErrorDialog
            // 
            AcceptButton = _okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            CancelButton = _okButton;
            ClientSize = new System.Drawing.Size(484, 293);
            Controls.Add(_layout);
            Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScriptErrorDialog";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Script Error";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            _layout.ResumeLayout(false);
            _layout.PerformLayout();
            _header.ResumeLayout(false);
            _header.PerformLayout();
            _footer.ResumeLayout(false);
            _footer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel _layout;
        private System.Windows.Forms.TableLayoutPanel _header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _exceptionMessage;
        private System.Windows.Forms.TextBox _exceptionDetails;
        private System.Windows.Forms.TableLayoutPanel _footer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button _okButton;
    }
}