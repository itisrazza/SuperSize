
namespace SuperSize.Forms
{
    partial class NotifyIconForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator s1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maxActiveWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.maxWindowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigForm = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            s1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // s1
            // 
            s1.Name = "s1";
            s1.Size = new System.Drawing.Size(356, 6);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SuperSize";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxActiveWindow,
            this.maxWindowMenu,
            s1,
            this.openConfigForm,
            this.quit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(360, 162);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // maxActiveWindow
            // 
            this.maxActiveWindow.Name = "maxActiveWindow";
            this.maxActiveWindow.Size = new System.Drawing.Size(359, 38);
            this.maxActiveWindow.Text = "SuperSize &Active Window";
            // 
            // maxWindowMenu
            // 
            this.maxWindowMenu.Name = "maxWindowMenu";
            this.maxWindowMenu.Size = new System.Drawing.Size(359, 38);
            this.maxWindowMenu.Text = "SuperSize &Window";
            // 
            // openConfigForm
            // 
            this.openConfigForm.Name = "openConfigForm";
            this.openConfigForm.Size = new System.Drawing.Size(359, 38);
            this.openConfigForm.Text = "&Settings...";
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(359, 38);
            this.quit.Text = "&Quit";
            // 
            // NotifyIconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "NotifyIconForm";
            this.Text = "NotifyIconForm";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem maxActiveWindow;
        private System.Windows.Forms.ToolStripMenuItem maxWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem openConfigForm;
        private System.Windows.Forms.ToolStripMenuItem quit;
    }
}