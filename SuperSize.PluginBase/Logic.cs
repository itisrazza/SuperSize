using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.PluginBase
{
    public abstract class Logic
    {
        /// <summary>
        /// The logic's display name in English.
        /// </summary>
        public abstract string DisplayName { get; }

        // TODO: localisation

        /// <summary>
        /// The logic's initial settings.
        /// <para />
        /// These will be the settings stored for the plugin when it's selected for the first time. The default implementation provides an empty <see cref="Settings"/> object.
        /// </summary>
        public virtual Dictionary<string, string> InitialSettings { get; } = new();


        public abstract Task<Rectangle> CalculateWindowSize(Screen[] screens, Settings settings);

        /// <summary>
        /// Action to be performed when the user clicks the "Settings..." button on the logic selection page.
        /// <para/>
        /// If your plugin does not support customizing its behaviour, use <see 
        /// </summary>
        /// <param name="settings">This logic's settings object.</param>
        /// <example>
        /// // No settings
        /// public override void OnSettings(Settings settings)
        /// {
        ///   DisplayNoSettingsMessage();
        /// }
        /// 
        /// // With settings
        /// public override void OnSettings(Settings settings)
        /// {
        ///   var settingsForm = new SettingsForm(settings);
        ///   var result = settingsForm.ShowDialog();
        ///   if (result == DialogResult.OK) settings.Save();
        /// }
        /// </example>
        public abstract void ShowSettings(Settings settings);

        /// <summary>
        /// Display message for logic not support configuration.
        /// </summary>
        protected void DisplayNoSettingsMessage()
        {
            MessageBox.Show(
                "This sizing logic does not support configuration.",
                DisplayName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}
