
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
            horizontalLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            verticalLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // horizontalLabel
            // 
            horizontalLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            horizontalLabel.Location = new System.Drawing.Point(0, 456);
            horizontalLabel.Name = "horizontalLabel";
            horizontalLabel.Size = new System.Drawing.Size(640, 24);
            horizontalLabel.TabIndex = 0;
            horizontalLabel.Text = "640";
            horizontalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            horizontalLabel.Click += OnClick;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = System.Drawing.Color.DarkBlue;
            titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(640, 24);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Test Window";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            titleLabel.Click += OnClick;
            // 
            // verticalLabel
            // 
            verticalLabel.Dock = System.Windows.Forms.DockStyle.Right;
            verticalLabel.Location = new System.Drawing.Point(576, 24);
            verticalLabel.Name = "verticalLabel";
            verticalLabel.Size = new System.Drawing.Size(64, 432);
            verticalLabel.TabIndex = 4;
            verticalLabel.Text = "480";
            verticalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            verticalLabel.Click += OnClick;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightGray;
            ClientSize = new System.Drawing.Size(640, 480);
            Controls.Add(verticalLabel);
            Controls.Add(titleLabel);
            Controls.Add(horizontalLabel);
            ForeColor = System.Drawing.Color.Black;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "TestForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "TestForm";
            Load += OnLoad;
            Click += OnClick;
            Leave += OnFocusLeave;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label horizontalLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label verticalLabel;
    }
}