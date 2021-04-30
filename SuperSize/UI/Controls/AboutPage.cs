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
    public partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {
            versionLbl.Text = Program.Version;
            groupBox2.Visible = new Random().Next(0, 10) < 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}
