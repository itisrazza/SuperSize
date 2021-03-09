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

namespace SuperSize.Forms
{
    public partial class KeyboardShortcutDialog : Form
    {
        private ModifierKeys _modifiers = 0;
        private Keys _key = 0;

        public ModifierKeys Modifiers
        {
            get => _modifiers;
            set
            {
                _modifiers = value;

                shiftCheckbox.Checked = ((_modifiers & OS.ModifierKeys.Shift) == OS.ModifierKeys.Shift);
                controlCheckbox.Checked = ((_modifiers & OS.ModifierKeys.Control) == OS.ModifierKeys.Control);
                windowsCheckbox.Checked = ((_modifiers & OS.ModifierKeys.Win) == OS.ModifierKeys.Win);
                altCheckbox.Checked = ((_modifiers & OS.ModifierKeys.Alt) == OS.ModifierKeys.Alt);
            }
        }

        public Keys Key
        {
            get => _key;
            set
            {
                _key = value;
                comboBox1.SelectedItem = _key;
            }
        }

        public KeyboardShortcutDialog()
        {
            InitializeComponent();
            PopulateKeysComboBox();
            okButton.Enabled = comboBox1.SelectedIndex >= 0;
            comboBox1.SelectedIndex = 0;
        }

        public KeyboardShortcutDialog(ModifierKeys modifiers, Keys keys)
        {
            InitializeComponent();
            PopulateKeysComboBox();
            Modifiers = modifiers;
            Key = keys;
            okButton.Enabled = comboBox1.SelectedIndex >= 0;
        }

        private void PopulateKeysComboBox()
            => comboBox1.Items.AddRange(Enum.GetValues<Keys>().Select(k => (object)k).ToArray());

        private void okButton_Click(object sender, EventArgs e)
        {
            _modifiers = 0;
            if (shiftCheckbox.Checked) _modifiers |= OS.ModifierKeys.Shift;
            if (controlCheckbox.Checked) _modifiers |= OS.ModifierKeys.Control;
            if (windowsCheckbox.Checked) _modifiers |= OS.ModifierKeys.Win;
            if (altCheckbox.Checked) _modifiers |= OS.ModifierKeys.Alt;

            _key = (Keys)comboBox1.SelectedItem;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            okButton.Enabled = comboBox1.SelectedIndex >= 0;
        }
    }
}
