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
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            // generate a window list
            maxWindowMenu.DropDownItems.Clear();
            maxWindowMenu.DropDownItems.AddRange(
                OS.Utilities.GetOpenWindows()
                    .Select((window) => new ToolStripDropDownButton { Text = window.Title })
                    .ToArray());
        }
    }
}
