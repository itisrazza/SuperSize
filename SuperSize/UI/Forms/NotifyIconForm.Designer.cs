
namespace SuperSize.UI.Forms
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
            this.maxWindowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.s2 = new System.Windows.Forms.ToolStripSeparator();
            this.openConfigForm = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            s1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip.SuspendLayout();
            this.windowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // s1
            // 
            s1.Name = "s1";
            s1.Size = new System.Drawing.Size(168, 6);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SuperSize";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxWindowMenu,
            s1,
            this.sendFeedback,
            this.s2,
            this.openConfigForm,
            this.quit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(172, 104);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // maxWindowMenu
            // 
            this.maxWindowMenu.DropDown = this.windowMenu;
            this.maxWindowMenu.Name = "maxWindowMenu";
            this.maxWindowMenu.Size = new System.Drawing.Size(171, 22);
            this.maxWindowMenu.Text = "SuperSize &Window";
            // 
            // windowMenu
            // 
            this.windowMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.windowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.windowMenu.Name = "windowMenu";
            this.windowMenu.OwnerItem = this.maxWindowMenu;
            this.windowMenu.Size = new System.Drawing.Size(427, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(426, 22);
            this.toolStripMenuItem1.Text = "Hello World - This is an example item. It\'s here only to size the box.";
            // 
            // sendFeedback
            // 
            this.sendFeedback.Name = "sendFeedback";
            this.sendFeedback.Size = new System.Drawing.Size(171, 22);
            this.sendFeedback.Text = "Send &Feedback...";
            this.sendFeedback.Click += new System.EventHandler(this.sendFeedback_Click);
            // 
            // s2
            // 
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(168, 6);
            // 
            // openConfigForm
            // 
            this.openConfigForm.Name = "openConfigForm";
            this.openConfigForm.Size = new System.Drawing.Size(171, 22);
            this.openConfigForm.Text = "&Settings...";
            this.openConfigForm.Click += new System.EventHandler(this.openConfigForm_Click);
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(171, 22);
            this.quit.Text = "&Quit";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // NotifyIconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(431, 211);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "NotifyIconForm";
            this.Text = "NotifyIconForm";
            this.Shown += new System.EventHandler(this.NotifyIconForm_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.windowMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem maxWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem openConfigForm;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.ContextMenuStrip windowMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendFeedback;
        private System.Windows.Forms.ToolStripSeparator s2;
    }
}