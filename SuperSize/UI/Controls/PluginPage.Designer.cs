
namespace SuperSize.UI.Controls
{
    partial class PluginPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator sep_123;
            this.footerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.linkPlugins = new System.Windows.Forms.LinkLabel();
            this.btnInstall = new System.Windows.Forms.Button();
            this.pluginListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.authorColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.locationColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.pluginMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblName = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            sep_123 = new System.Windows.Forms.ToolStripSeparator();
            this.footerPanel.SuspendLayout();
            this.pluginMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sep_123
            // 
            sep_123.Name = "sep_123";
            sep_123.Size = new System.Drawing.Size(177, 6);
            // 
            // footerPanel
            // 
            this.footerPanel.AutoSize = true;
            this.footerPanel.ColumnCount = 3;
            this.footerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.footerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.footerPanel.Controls.Add(this.btnRemove, 2, 0);
            this.footerPanel.Controls.Add(this.linkPlugins, 0, 0);
            this.footerPanel.Controls.Add(this.btnInstall, 1, 0);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.footerPanel.Location = new System.Drawing.Point(0, 404);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.RowCount = 1;
            this.footerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footerPanel.Size = new System.Drawing.Size(376, 29);
            this.footerPanel.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(273, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "&Show Folder";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // linkPlugins
            // 
            this.linkPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkPlugins.Location = new System.Drawing.Point(3, 0);
            this.linkPlugins.Name = "linkPlugins";
            this.linkPlugins.Size = new System.Drawing.Size(158, 29);
            this.linkPlugins.TabIndex = 0;
            this.linkPlugins.TabStop = true;
            this.linkPlugins.Text = "Get additional plugins...";
            this.linkPlugins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPlugins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPlugins_LinkClicked);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(167, 3);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(100, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "&Install...";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // pluginListView
            // 
            this.pluginListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.authorColumnHeader,
            this.locationColumnHeader});
            this.pluginListView.ContextMenuStrip = this.pluginMenuStrip;
            this.pluginListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginListView.HideSelection = false;
            this.pluginListView.Location = new System.Drawing.Point(0, 0);
            this.pluginListView.Name = "pluginListView";
            this.pluginListView.Size = new System.Drawing.Size(376, 404);
            this.pluginListView.TabIndex = 4;
            this.pluginListView.UseCompatibleStateImageBehavior = false;
            this.pluginListView.View = System.Windows.Forms.View.Details;
            this.pluginListView.SelectedIndexChanged += new System.EventHandler(this.pluginListView_SelectedIndexChanged);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 120;
            // 
            // authorColumnHeader
            // 
            this.authorColumnHeader.Text = "Author";
            this.authorColumnHeader.Width = 120;
            // 
            // locationColumnHeader
            // 
            this.locationColumnHeader.Text = "Location";
            this.locationColumnHeader.Width = 180;
            // 
            // pluginMenuStrip
            // 
            this.pluginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblName,
            this.lblAuthor,
            sep_123,
            this.btnMenuRemove,
            this.btnShowLocation});
            this.pluginMenuStrip.Name = "pluginMenuStrip";
            this.pluginMenuStrip.Size = new System.Drawing.Size(181, 98);
            // 
            // lblName
            // 
            this.lblName.Enabled = false;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 22);
            this.lblName.Text = "toolStripMenuItem1";
            this.lblName.ToolTipText = "Plugin Name";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Enabled = false;
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(180, 22);
            this.lblAuthor.Text = "Plugin Author";
            // 
            // btnMenuRemove
            // 
            this.btnMenuRemove.Name = "btnMenuRemove";
            this.btnMenuRemove.Size = new System.Drawing.Size(180, 22);
            this.btnMenuRemove.Text = "Remove";
            this.btnMenuRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShowLocation
            // 
            this.btnShowLocation.Name = "btnShowLocation";
            this.btnShowLocation.Size = new System.Drawing.Size(180, 22);
            this.btnShowLocation.Text = "Show in Explorer";
            this.btnShowLocation.Click += new System.EventHandler(this.btnShowLocation_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "dll";
            this.openFileDialog1.FileName = "*.dll";
            this.openFileDialog1.Filter = "DLL files|*.dll|All files|*.*";
            this.openFileDialog1.Title = "Install SuperSize Plugin";
            // 
            // PluginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pluginListView);
            this.Controls.Add(this.footerPanel);
            this.Name = "PluginPage";
            this.Size = new System.Drawing.Size(376, 433);
            this.Load += new System.EventHandler(this.PluginPage_Load);
            this.footerPanel.ResumeLayout(false);
            this.pluginMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel footerPanel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.LinkLabel linkPlugins;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ListView pluginListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader authorColumnHeader;
        private System.Windows.Forms.ColumnHeader locationColumnHeader;
        private System.Windows.Forms.ContextMenuStrip pluginMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem lblName;
        private System.Windows.Forms.ToolStripMenuItem lblAuthor;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRemove;
        private System.Windows.Forms.ToolStripMenuItem btnShowLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
