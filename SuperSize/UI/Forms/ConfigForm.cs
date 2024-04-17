using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSize.Model;
using SuperSize.OS;
using static SuperSize.Model.KeyboardShortcut;
using SuperSize.Service;
using SuperSize.UI.Dialogs;

namespace SuperSize.UI.Forms
{
    public partial class ConfigForm : Form
    {
        private Rectangle? _windowPreview = null;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                var logic = SizeService.SelectedLogic;
                var result = logic.Calculate();

                new TestForm
                {
                    Location = result.Location,
                    Size = result.Size
                }.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.ToString(),
                    $"Script error occurred: {ex.Message}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            try
            {
                var logic = SizeService.SelectedLogic;
                var result = logic.Calculate();
                _windowPreview = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.ToString(),
                    $"Script error occurred: {ex.Message}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
