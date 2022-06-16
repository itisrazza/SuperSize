using SuperSize.PluginBase;
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

        private PluginBase? SelectedPlugin => pluginListView.SelectedItems.Count == 0
            ? null
            : pluginListView.SelectedItems[0].Tag as PluginBase;

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
            Utilities.ShowInExplorer(PluginService.UserPluginFolder);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();
            if (res != DialogResult.OK) return;

            try
            {
                PluginService.InstallPlugin(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Plugin Install Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void linkPlugins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.OpenLink("https://github.com/thegreatrazz/SuperSize/wiki/Plugins");
        }
    }
}
