
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator s1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconForm));
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            maxWindowMenu = new System.Windows.Forms.ToolStripMenuItem();
            windowMenu = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            sendFeedback = new System.Windows.Forms.ToolStripMenuItem();
            s2 = new System.Windows.Forms.ToolStripSeparator();
            openConfigForm = new System.Windows.Forms.ToolStripMenuItem();
            quit = new System.Windows.Forms.ToolStripMenuItem();
            s1 = new System.Windows.Forms.ToolStripSeparator();
            contextMenuStrip.SuspendLayout();
            windowMenu.SuspendLayout();
            SuspendLayout();
            // 
            // s1
            // 
            s1.Name = "s1";
            s1.Size = new System.Drawing.Size(168, 6);
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "SuperSize";
            notifyIcon.Visible = true;
            notifyIcon.MouseClick += notifyIcon_MouseClick;
            notifyIcon.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { maxWindowMenu, s1, sendFeedback, s2, openConfigForm, quit });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new System.Drawing.Size(172, 104);
            contextMenuStrip.Opening += contextMenuStrip_Opening;
            // 
            // maxWindowMenu
            // 
            maxWindowMenu.DropDown = windowMenu;
            maxWindowMenu.Name = "maxWindowMenu";
            maxWindowMenu.Size = new System.Drawing.Size(171, 22);
            maxWindowMenu.Text = "SuperSize &Window";
            // 
            // windowMenu
            // 
            windowMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            windowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1 });
            windowMenu.Name = "windowMenu";
            windowMenu.OwnerItem = maxWindowMenu;
            windowMenu.Size = new System.Drawing.Size(426, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(425, 22);
            toolStripMenuItem1.Text = "Hello World - This is an example item. It's here only to size the box.";
            // 
            // sendFeedback
            // 
            sendFeedback.Name = "sendFeedback";
            sendFeedback.Size = new System.Drawing.Size(171, 22);
            sendFeedback.Text = "Send &Feedback...";
            sendFeedback.Click += sendFeedback_Click;
            // 
            // s2
            // 
            s2.Name = "s2";
            s2.Size = new System.Drawing.Size(168, 6);
            // 
            // openConfigForm
            // 
            openConfigForm.Name = "openConfigForm";
            openConfigForm.Size = new System.Drawing.Size(171, 22);
            openConfigForm.Text = "&Settings...";
            openConfigForm.Click += openConfigForm_Click;
            // 
            // quit
            // 
            quit.Name = "quit";
            quit.Size = new System.Drawing.Size(171, 22);
            quit.Text = "&Quit";
            quit.Click += quit_Click;
            // 
            // NotifyIconForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(431, 211);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "NotifyIconForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NotifyIconForm";
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
            Shown += NotifyIconForm_Shown;
            contextMenuStrip.ResumeLayout(false);
            windowMenu.ResumeLayout(false);
            ResumeLayout(false);

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