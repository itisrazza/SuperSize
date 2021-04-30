using SuperSize.Model;
using SuperSize.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.UI.Forms
{
    public partial class NotifyIconForm : Form
    {
        public NotifyIconForm()
        {
            InitializeComponent();
            PopulateWindowList();
        }

        private void PopulateWindowList()
        {
            // generate a window list
            windowMenu.Items.Clear();
            windowMenu.Items.AddRange(
                OS.Utilities.GetOpenWindows()
                    .OrderBy(a => a.Title)
                    .Select((window) =>
                    {
                        var item = new ToolStripMenuItem
                        {
                            Text = window.Title
                        };
                        item.Click += (_, _) => Sizer.SizeWindow(window.Handle);

                        return item;
                    })
                    .ToArray());
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    PopulateWindowList();
                    break;
                default:
                    break;
            }
        }

        private void NotifyIconForm_Shown(object sender, EventArgs e)
        {
            Hide();

            // if the user hasn't been onboarded, do that now
            if (!Properties.Settings.Default.WasOnboarded)
            {
                new WelcomeForm().Show();
            }
        }

        private void openConfigForm_Click(object sender, EventArgs e)
        {
            var configForm = new ConfigForm();
            configForm.Show();
        }

        private void maxActiveWindow_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(100);
                MessageBox.Show(Window.GetForegroundWindow().Text);
            });
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void sendFeedback_Click(object sender, EventArgs e)
        {
            var procInfo = new ProcessStartInfo();
            procInfo.FileName = "cmd.exe";
            procInfo.ArgumentList.Add("/c");
            procInfo.ArgumentList.Add("start");
            procInfo.ArgumentList.Add("https://github.com/thegreatrazz/SuperSize/issues/new");

            Process.Start(procInfo);
        }
    }
}
