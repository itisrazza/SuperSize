using Microsoft.Scripting.Hosting;
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
using Screen = SuperSize.Model.Screen;
using SuperSize.OS;
using SuperSize.Forms;
using static SuperSize.Model.KeyboardShortcut;

namespace SuperSize
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            keybindPreview_Update();
        }

        private void RenderDisplayConfiguration(Bitmap bmp)
        {
            var gfx = Graphics.FromImage(bmp);

            // get displays
            var screens = Screen.GetAllScreens();
            var screenBounds = DisplayUtils.GetAllScreenBounds();

            // calculate scaling factors
            var scale = Math.Min(
                (double)(bmp.Width - 4) / screenBounds.Width,
                (double)(bmp.Height - 4) / screenBounds.Height);
            var mappedScreenBounds = new Rectangle(
                bmp.Width / 2 - (int)(scale * screenBounds.Width) / 2,
                bmp.Height / 2 - (int)(scale * screenBounds.Height) / 2,
                (int)(scale * screenBounds.Width),
                (int)(scale * screenBounds.Height));

            // draw the screens
            var settings = Properties.Settings.Default;
            using var screenFill = new SolidBrush(settings.ScreenFillColor);
            using var primaryScreenFill = new SolidBrush(settings.PrimaryScreenFillColor);
            using var screenText = new SolidBrush(settings.ScreenTextColor);
            using var screenBorder = new Pen(settings.ScreenBorderColor);
            using var screenFont = new Font("Segoe UI", 9);
            var count = 0;
            foreach (var screen in screens)
            {
                var bounds = screen.Bounds;
                var rect = new Rectangle(
                    (int)(mappedScreenBounds.X + scale * (bounds.X - screenBounds.X)),
                    (int)(mappedScreenBounds.Y + scale * (bounds.Y - screenBounds.Y)),
                    (int)(scale * bounds.Width),
                    (int)(scale * bounds.Height));

                gfx.FillRectangle(screen.Primary ? primaryScreenFill : screenFill, rect);

                var str = (++count).ToString();
                var strSize = gfx.MeasureString(str, screenFont);
                gfx.DrawString(
                    str,
                    screenFont,
                    screenText,
                    rect.X + rect.Width / 2 - strSize.Width / 2,
                    rect.Y + rect.Height / 2 - strSize.Height / 2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var (width, height) = _configPreview.Size;
            if (width <= 0 || height <= 0) return;
            var bmp = new Bitmap(width, height);
            RenderDisplayConfiguration(bmp);
            _configPreview.Image = bmp;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            var screen = System.Windows.Forms.Screen.PrimaryScreen;

            new Forms.TestForm
            {
                Location = screen.Bounds.Location,
                Size = screen.WorkingArea.Size
            }.Show();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {

        }

        private void keybindPreview_Update()
        {
            var globalShortcut = Program.GetGlobalKeyboardShortcut();
            keybindPreview.Text = globalShortcut.ToString();
        }

        private void keybindChangeButton_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            using var keyboardShortcutDialog = new KeyboardShortcutDialog(
                new()
                {
                    Modifier = (ModifierKeys)settings.ShortcutModifier,
                    Key = (Keys)settings.ShortcutKey
                });

            var result = keyboardShortcutDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            settings.ShortcutKey = (uint)keyboardShortcutDialog.Key;
            settings.ShortcutModifier = (uint)keyboardShortcutDialog.Modifier;
            settings.Save();

            keybindPreview_Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == _aboutPage)
            {
                tabControl1.SelectedTab = tabPage1;
                new AboutBox().ShowDialog();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == _aboutPage)
            {
                tabControl1.SelectedTab = tabPage1;
                new AboutBox().ShowDialog();
            }
        }
    }
}
