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

            // populate the script chooser
            builtinScriptChooser.Items.Clear();
            builtinScriptChooser.Items.AddRange(Sizer.KnownBuiltInScripts.ToArray());
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            keybindPreview_Update();

            var settings = Properties.Settings.Default;
            textBox1.Text = settings.Script;        // load the script before checkbox
            customScriptRadio.Checked = settings.UseCustomScript;
            builtinScriptChooser.SelectedItem = settings.BuiltinScript;
            customScriptRadio_CheckedChanged(sender, e);
        }

        private void RenderDisplayConfiguration(Bitmap bmp)
        {
            var gfx = Graphics.FromImage(bmp);
            var dpiScale = Math.Max(gfx.DpiX, gfx.DpiY) / 96;

            // get displays
            var screens = Screen.GetAllScreens();
            var screenBounds = Utilities.GetAllScreenBounds();

            // calculate scaling factors
            var scale = Math.Min(
                (double)(bmp.Width - 4 * dpiScale) / screenBounds.Width,
                (double)(bmp.Height - 4 * dpiScale) / screenBounds.Height);
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
            using var screenBorder = new Pen(settings.ScreenBorderColor, dpiScale);
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

            // draw the preview
            if (_windowPreview != null)
            {
                using var previewBorder = new Pen(settings.WindowPreviewBorder, dpiScale);
                var rect = _windowPreview.Value;
                var previewRect = new Rectangle(
                    (int)(mappedScreenBounds.X + scale * (rect.X - screenBounds.X)),
                    (int)(mappedScreenBounds.Y + scale * (rect.Y - screenBounds.Y)),
                    (int)(scale * rect.Width),
                    (int)(scale * rect.Height));
                gfx.DrawRectangle(previewBorder, previewRect);
            }
        }

        private void SaveScript()
        {
            var settings = Properties.Settings.Default;
            if (settings.UseCustomScript = customScriptRadio.Checked)
            {
                settings.Script = textBox1.Text;
            }
            else
            {
                settings.BuiltinScript = builtinScriptChooser.SelectedItem as string;
            }
            settings.Save();
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
            try
            {
                var logic = Sizer.SelectedLogic();
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
                var logic = Sizer.SelectedLogic();
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
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save the config
            SaveScript();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            SaveScript();
        }

        private void customScriptRadio_CheckedChanged(object sender, EventArgs e)
        {
            var useCustomScript = customScriptRadio.Checked;
            textBox1.Enabled = useCustomScript;
            textBox1.ReadOnly = !useCustomScript;
            builtinScriptChooser.Enabled = !useCustomScript;
            SaveScript();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            var response = MessageBox.Show(
                this,
                "What have you royally screwed up so much that you need to reset the program settings? Are you sure you want to do this?",
                "Settings Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (response != DialogResult.Yes)
            {
                MessageBox.Show(
                    this,
                    "I'll let you off the hook for now...",
                    "Operation Cancelled");
                return;
            }

            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();

            MessageBox.Show("Please restart the application.");
            Program.Exit();
        }
    }
}
