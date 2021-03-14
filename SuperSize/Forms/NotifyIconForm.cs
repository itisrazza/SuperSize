using SuperSize.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.Forms
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

        private void NotifyIconForm_Shown(object sender, EventArgs e) => Hide();

        private void openConfigForm_Click(object sender, EventArgs e)
        {
            var configForm = new ConfigForm();
            configForm.Show();
        }

        private void maxActiveWindow_Click(object sender, EventArgs e)
        {
            // TODO: get active window and pass it to Service.Sizer
        }

        private void quit_Click(object sender, EventArgs e)
        {
            // TODO: quit the program, cleaning up native resources
        }
    }
}
