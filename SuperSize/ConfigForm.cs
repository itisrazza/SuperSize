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

namespace SuperSize
{
    public partial class ConfigForm : Form
    {

        private Config _config = new Config();

        private Dictionary<string, string> _builtInScritps = new()
        {
            { "Use all the screen real estate", "~/SwallowEverything.py" },
        };

        public ConfigForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(
                _builtInScritps.Select(pair => pair.Key).ToArray());
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
        }

        private void RenderDisplayConfiguration(Bitmap bmp)
        {
            var gfx = Graphics.FromImage(bmp);

            // get displays
            var screens = Screen.AllScreens;
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
            using var screenFill = new SolidBrush(_config.ScreenFillColor);
            using var primaryScreenFill = new SolidBrush(_config.PrimaryScreenFillColor);
            using var screenText = new SolidBrush(_config.ScreenTextColor);
            using var screenBorder = new Pen(_config.ScreenBorderColor);
            using var screenFont = new Font(_config.ScreenTextFontFamily, 9);
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

        private void button1_Click(object sender, EventArgs e)
        {
            new Executor(rect =>
            {
                MessageBox.Show(rect.ToString());
            }).Run(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(
                Path.Join(
                    Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                    "Scripts",
                    _builtInScritps[(string)comboBox1.SelectedItem]));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            comboBox1.Text = $"Imported ({Path.GetFileName(openFileDialog.FileName)})";
        }
    }
}
