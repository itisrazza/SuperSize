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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = $"Test Window - {Location.X}, {Location.Y} ({Width}x{Height})";
            horizontalLabel.Text = Width.ToString();
            verticalLabel.Text = Height.ToString();
        }

        private void TestForm_Click(object sender, EventArgs e) => Close();
    }
}
