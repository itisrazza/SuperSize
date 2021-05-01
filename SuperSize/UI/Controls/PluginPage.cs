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

namespace SuperSize.UI.Controls
{
    public partial class PluginPage : UserControl
    {
        public PluginPage()
        {
            InitializeComponent();
        }

        private void PluginPage_Load(object sender, EventArgs e)
        {
            foreach (var plugin in PluginService.Plugins)
            {
                var item = new ListViewItem(new string[] { plugin.Name, plugin.Author, plugin.DllPath() });
                pluginListView.Items.Add(item);
            }
        }
    }
}
