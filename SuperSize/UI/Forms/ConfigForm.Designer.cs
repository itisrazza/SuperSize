
namespace SuperSize.UI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            _aboutPage = new System.Windows.Forms.TabPage();
            aboutPage1 = new Controls.AboutPage();
            tabControl1 = new System.Windows.Forms.TabControl();
            _homePage = new System.Windows.Forms.TabPage();
            settingsPage2 = new Controls.SettingsPage();
            settingsPage1 = new Controls.SettingsPage();
            _aboutPage.SuspendLayout();
            tabControl1.SuspendLayout();
            _homePage.SuspendLayout();
            SuspendLayout();
            // 
            // _aboutPage
            // 
            _aboutPage.Controls.Add(aboutPage1);
            _aboutPage.Location = new System.Drawing.Point(4, 24);
            _aboutPage.Name = "_aboutPage";
            _aboutPage.Padding = new System.Windows.Forms.Padding(3);
            _aboutPage.Size = new System.Drawing.Size(376, 433);
            _aboutPage.TabIndex = 1;
            _aboutPage.Text = "About";
            _aboutPage.UseVisualStyleBackColor = true;
            // 
            // aboutPage1
            // 
            aboutPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            aboutPage1.Location = new System.Drawing.Point(3, 3);
            aboutPage1.Name = "aboutPage1";
            aboutPage1.Size = new System.Drawing.Size(370, 427);
            aboutPage1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(_homePage);
            tabControl1.Controls.Add(_aboutPage);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(384, 461);
            tabControl1.TabIndex = 0;
            // 
            // _homePage
            // 
            _homePage.Controls.Add(settingsPage2);
            _homePage.Location = new System.Drawing.Point(4, 24);
            _homePage.Name = "_homePage";
            _homePage.Padding = new System.Windows.Forms.Padding(3);
            _homePage.Size = new System.Drawing.Size(376, 433);
            _homePage.TabIndex = 3;
            _homePage.Text = "Settings";
            _homePage.UseVisualStyleBackColor = true;
            // 
            // settingsPage2
            // 
            settingsPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            settingsPage2.Location = new System.Drawing.Point(3, 3);
            settingsPage2.Name = "settingsPage2";
            settingsPage2.Size = new System.Drawing.Size(370, 427);
            settingsPage2.TabIndex = 0;
            // 
            // settingsPage1
            // 
            settingsPage1.Location = new System.Drawing.Point(383, 165);
            settingsPage1.Name = "settingsPage1";
            settingsPage1.Size = new System.Drawing.Size(8, 8);
            settingsPage1.TabIndex = 1;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(384, 461);
            Controls.Add(settingsPage1);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfigForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SuperSize Settings";
            FormClosing += ConfigForm_FormClosing;
            Load += ConfigForm_Load;
            _aboutPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            _homePage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aboutPage;
        private UI.Controls.AboutPage aboutPage1;
        private System.Windows.Forms.TabPage _homePage;
        private UI.Controls.SettingsPage settingsPage2;
        private UI.Controls.SettingsPage settingsPage1;
        private System.Windows.Forms.TabPage _aboutPage;
    }
}

