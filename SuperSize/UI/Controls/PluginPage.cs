using SuperSize.Plugin;
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

        private PluginBase? SelectedPlugin
        {
            get
            {
                if (pluginListView.SelectedItems.Count == 0) return null;
                return pluginListView.SelectedItems[0].Tag as PluginBase;
            }
        }

        private void PluginPage_Load(object sender, EventArgs e)
        {
            foreach (var plugin in PluginService.Plugins)
            {
                var item = new ListViewItem(new string[] { plugin.Name, plugin.Author, plugin.DllPath() })
                {
                    Tag = plugin
                };
                pluginListView.Items.Add(item);
            }
        }

        private void pluginListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pluginListView.SelectedItems.Count == 0)
            {
                pluginListView.ContextMenuStrip = null;
                return;
            }

            pluginListView.ContextMenuStrip = pluginMenuStrip;
            UpdatePluginMenuStrip();
        }

        private void UpdatePluginMenuStrip()
        {
            lblName.Text = SelectedPlugin?.Name;
            lblAuthor.Text = SelectedPlugin?.Author;
        }

        private void btnShowLocation_Click(object sender, EventArgs e)
        {
            var plugin = SelectedPlugin;
            if (plugin == null) return;

            Utilities.ShowInExplorer(plugin.DllPath());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SuperSize doesn't currently support removing plugins. You can for the time being remove the DLLs while SuperSize is not running.",
                "Uninstall Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SuperSize doesn't currently support installing plugins. You can for the time being add them to the folder and we'll load them next time SuperSize starts.",
                "Install Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            Utilities.ShowInExplorer(PluginService.UserPluginFolder);
        }
    }
}
