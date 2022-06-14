using SuperSize.Plugin;
using SuperSize.Service;
using SuperSize.UI.Dialogs;
using SuperSize.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SuperSize.Model.KeyboardShortcut;

namespace SuperSize.UI.Controls
{
    public partial class SettingsPage : UserControl
    {
        private Rectangle? _windowPreview;

        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            // add logic to the combo box
            comboBox1.Items.AddRange(SizeService.KnownLogic.Select((logic) => logic).ToArray());
            comboBox1.SelectedItem = SizeService.SelectedLogic;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;   // late bind this event

            // update components
            UpdateSizePreview();
            UpdateKeybindPreview();
        }

        private void UpdateSizePreview()
        {
            _windowPreview = SizeService.SelectedLogic?.Calculate();
            var bmp = new Bitmap(previewBox.Width, previewBox.Height);
            RenderDisplayConfiguration(bmp);
            previewBox.Image?.Dispose();
            previewBox.Image = bmp;
        }

        private void RenderDisplayConfiguration(Bitmap bmp)
        {
            var gfx = Graphics.FromImage(bmp);
            var dpiScale = Math.Max(gfx.DpiX, gfx.DpiY) / 96;

            // get displays
            var screens = Screen.AllScreens;
            var screenBounds = OS.Utilities.GetAllScreenBounds();

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

        private void SettingsPage_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is LogicBase logic)
            {
                SizeService.SelectedLogic = logic;
                settingsBtn.Enabled = logic.HasConfig;
            }
            UpdateSizePreview();
        }

        public void Save()
        {

        }

        //
        // keybind stuff
        //

        private void keybindChangeBtn_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            var shortcut = KeyboardShortcutDialog.ShowDialog((Keys)settings.ShortcutKey, (ModifierKeys)settings.ShortcutModifier);
            if (shortcut == null) return;

            settings.ShortcutKey = (uint)shortcut.Value.Key;
            settings.ShortcutModifier = (uint)shortcut.Value.Modifier;
            settings.Save();

            UpdateKeybindPreview();
        }

        private void UpdateKeybindPreview()
        {
            var globalShortcut = Program.GetGlobalKeyboardShortcut();
            keybindPreviewLbl.Text = globalShortcut.ToString();
        }

        private void settingsBtn_Click_1(object sender, EventArgs e)
        {
            var plugin = SizeService.SelectedLogic;
            if (plugin == null) return;

            plugin.DoConfig(ConfigService.GetConfigProvider());
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            var logic = SizeService.SelectedLogic;
            var result = logic?.Calculate();

            if (result == null) {
                MessageBox.Show("The logic didn't return a result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new TestForm
            {
                Location = result.Value.Location,
                Size = result.Value.Size
            }.Show();
        }
    }
}
