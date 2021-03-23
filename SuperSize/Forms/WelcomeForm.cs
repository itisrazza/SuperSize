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
    public partial class WelcomeForm : Form
    {
        public static List<(Image Image, string Text)> UserIntroduction = new()
        {
            { (Properties.Resources.Welcome, "Welcome to SuperSize. Let’s get you up to speed.") },
            { (Properties.Resources.System_Tray, "SuperSize runs in the background. You can access it’s settings by right clicking its icon in the system tray.") },
            { (Properties.Resources.Keyboard_Shortcut, "To super-size the active window, use Windows + Esc. You can change the keyboard shortcut in the settings.") },
            { (Properties.Resources.Dev_Build_Warning, "This is an active development build. Please report any issues on GitHub. See ‘Send Feedback’ in the SuperSize tray menu.") },
            { (Properties.Resources.Finish, "Ka pai. You are ready to go.") }
        };

        private int _introIndex = 0;
        private Image CurrentImage => UserIntroduction[_introIndex].Image;
        private string CurrentText => UserIntroduction[_introIndex].Text;

        public WelcomeForm()
        {
            InitializeComponent();
            UpdateImage();
        }

        public void UpdateImage()
        {
            pictureBox1.Image = CurrentImage;
            label1.Text = CurrentText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (++_introIndex == UserIntroduction.Count-1)
            {
                SuspendLayout();
                nextButton.Visible = false;
                skipButton.Visible = false;
                startButton.Visible = true;
                ResumeLayout();
            }
            UpdateImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ConfigForm().Show();
            Close();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
