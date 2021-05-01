
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
            this._aboutPage = new System.Windows.Forms.TabPage();
            this.aboutPage1 = new SuperSize.UI.Controls.AboutPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pluginPage = new System.Windows.Forms.TabPage();
            this.pluginPage1 = new SuperSize.UI.Controls.PluginPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.settingsPage2 = new SuperSize.UI.Controls.SettingsPage();
            this.settingsPage1 = new SuperSize.UI.Controls.SettingsPage();
            this._aboutPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pluginPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _aboutPage
            // 
            this._aboutPage.Controls.Add(this.aboutPage1);
            this._aboutPage.Location = new System.Drawing.Point(4, 24);
            this._aboutPage.Name = "_aboutPage";
            this._aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this._aboutPage.Size = new System.Drawing.Size(376, 433);
            this._aboutPage.TabIndex = 1;
            this._aboutPage.Text = "About";
            this._aboutPage.UseVisualStyleBackColor = true;
            // 
            // aboutPage1
            // 
            this.aboutPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPage1.Location = new System.Drawing.Point(3, 3);
            this.aboutPage1.Name = "aboutPage1";
            this.aboutPage1.Size = new System.Drawing.Size(370, 427);
            this.aboutPage1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.pluginPage);
            this.tabControl1.Controls.Add(this._aboutPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // pluginPage
            // 
            this.pluginPage.Controls.Add(this.pluginPage1);
            this.pluginPage.Location = new System.Drawing.Point(4, 24);
            this.pluginPage.Name = "pluginPage";
            this.pluginPage.Padding = new System.Windows.Forms.Padding(3);
            this.pluginPage.Size = new System.Drawing.Size(376, 433);
            this.pluginPage.TabIndex = 2;
            this.pluginPage.Text = "Plugins";
            this.pluginPage.UseVisualStyleBackColor = true;
            // 
            // pluginPage1
            // 
            this.pluginPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pluginPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginPage1.Location = new System.Drawing.Point(3, 3);
            this.pluginPage1.Name = "pluginPage1";
            this.pluginPage1.Size = new System.Drawing.Size(370, 427);
            this.pluginPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.settingsPage2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 433);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // settingsPage2
            // 
            this.settingsPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPage2.Location = new System.Drawing.Point(3, 3);
            this.settingsPage2.Name = "settingsPage2";
            this.settingsPage2.Size = new System.Drawing.Size(370, 427);
            this.settingsPage2.TabIndex = 0;
            // 
            // settingsPage1
            // 
            this.settingsPage1.Location = new System.Drawing.Point(383, 165);
            this.settingsPage1.Name = "settingsPage1";
            this.settingsPage1.Size = new System.Drawing.Size(8, 8);
            this.settingsPage1.TabIndex = 1;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.settingsPage1);
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
            this.tabControl1.ResumeLayout(false);
            this.pluginPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.TabPage pluginPage;
        private UI.Controls.PluginPage pluginPage1;
        private UI.Controls.AboutPage aboutPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UI.Controls.SettingsPage settingsPage2;
        private UI.Controls.SettingsPage settingsPage1;
        private System.Windows.Forms.TabPage _aboutPage;
    }
}

