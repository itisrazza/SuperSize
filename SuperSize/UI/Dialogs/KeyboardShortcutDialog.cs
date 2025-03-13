using SuperSize.Model;
using SuperSize.OS;
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
using ModKeys = SuperSize.Model.KeyboardShortcut.ModifierKeys;

namespace SuperSize.UI.Dialogs
{
    public partial class KeyboardShortcutDialog : Form
    {
        private KeyboardShortcut _shortcut;

        public KeyboardShortcut Shortcut
        {
            get => _shortcut;
            set
            {
                _shortcut = value;

                keySelector.SelectedItem = _shortcut.Key;
                shiftCheckbox.Checked = ((_shortcut.Modifier & ModKeys.Shift) == ModKeys.Shift);
                controlCheckbox.Checked = ((_shortcut.Modifier & ModKeys.Control) == ModKeys.Control);
                windowsCheckbox.Checked = ((_shortcut.Modifier & ModKeys.Windows) == ModKeys.Windows);
                altCheckbox.Checked = ((_shortcut.Modifier & ModKeys.Alt) == ModKeys.Alt);
            }
        }

        public Keys Key => Shortcut.Key;

        public ModKeys Modifier => Shortcut.Modifier;

        public KeyboardShortcutDialog()
        {
            InitializeComponent();
            PopulateKeysComboBox();
            AssignModifierTags();
            Shortcut = None;
            okButton.Enabled = keySelector.SelectedIndex >= 0;
        }

        public KeyboardShortcutDialog(KeyboardShortcut shortcut = default)
        {
            InitializeComponent();
            PopulateKeysComboBox();
            AssignModifierTags();
            Shortcut = shortcut;
            okButton.Enabled = keySelector.SelectedIndex >= 0;
        }

        public static KeyboardShortcut? ShowDialog(KeyboardShortcut? shortcut)
        {
            var dialog = new KeyboardShortcutDialog(shortcut ?? None);
            var result = dialog.ShowDialog();

            return result == DialogResult.OK ? dialog.Shortcut : null;
        }

        public static KeyboardShortcut? ShowDialog(Keys keys, ModKeys modifier)
        {
            return ShowDialog(new(keys, modifier));
        }

        private void AssignModifierTags()
        {
            controlCheckbox.Tag = ModKeys.Control;
            windowsCheckbox.Tag = ModKeys.Windows;
            altCheckbox.Tag = ModKeys.Alt;
            shiftCheckbox.Tag = ModKeys.Shift;
        }

        private void PopulateKeysComboBox()
            => keySelector.Items.AddRange(Enum.GetValues<Keys>().Select(k => (object)k).ToArray());

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            okButton.Enabled = keySelector.SelectedIndex >= 0;
        }

        private void modifierCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not CheckBox checkBox) return;
            if (checkBox.Tag is not ModKeys mod) return;

            if (checkBox.Checked)
                _shortcut.Modifier |= mod;
            else
                _shortcut.Modifier ^= mod;
        }

        private void keySelector_SelectedValueChanged(object sender, EventArgs e)
        {
            _shortcut.Key = (Keys)keySelector.SelectedItem!;
        }
    }
}
