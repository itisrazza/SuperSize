using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperSize.UI.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public static void Show(Rectangle rectangle)
        {
            new TestForm
            {
                Location = rectangle.Location,
                Size = rectangle.Size,
            }.Show();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            titleLabel.Text = $"Test Window - {Location.X}, {Location.Y} ({Width}x{Height})";
            horizontalLabel.Text = Width.ToString();
            verticalLabel.Text = Height.ToString();
        }

        private void OnClick(object sender, EventArgs e) => Close();

        private void OnFocusLeave(object sender, EventArgs e) => Close();
    }
}
