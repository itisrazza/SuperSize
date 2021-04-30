
namespace SuperSize.UI.Forms
{
    partial class TestForm
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
            this.horizontalLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.verticalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // horizontalLabel
            // 
            this.horizontalLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLabel.Location = new System.Drawing.Point(0, 456);
            this.horizontalLabel.Name = "horizontalLabel";
            this.horizontalLabel.Size = new System.Drawing.Size(640, 24);
            this.horizontalLabel.TabIndex = 0;
            this.horizontalLabel.Text = "640";
            this.horizontalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.horizontalLabel.Click += new System.EventHandler(this.TestForm_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(640, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Test Window";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.TestForm_Click);
            // 
            // verticalLabel
            // 
            this.verticalLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.verticalLabel.Location = new System.Drawing.Point(576, 24);
            this.verticalLabel.Name = "verticalLabel";
            this.verticalLabel.Size = new System.Drawing.Size(64, 432);
            this.verticalLabel.TabIndex = 4;
            this.verticalLabel.Text = "480";
            this.verticalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.verticalLabel.Click += new System.EventHandler(this.TestForm_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.verticalLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.horizontalLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.Click += new System.EventHandler(this.TestForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label horizontalLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label verticalLabel;
    }
}