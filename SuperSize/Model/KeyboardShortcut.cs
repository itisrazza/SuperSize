using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.Model
{
    public struct KeyboardShortcut
    {
        public Keys Key { get; set; }

        public ModifierKeys Modifier { get; set; }

        public override string ToString()
        {
            if (Key == Keys.None || Modifier == ModifierKeys.None)
                return "(none)";

            var sb = new StringBuilder();
            foreach (var mod in Enum.GetValues<ModifierKeys>())
            {
                if (mod == ModifierKeys.None) continue;
                if (sb.Length > 0) sb.Append(" + ");
                if ((Modifier & mod) == mod) sb.Append(mod);
            }
            return sb.Append(" + ").Append(Key).ToString();
        }
        public override bool Equals(object? obj)
        {
            return obj is KeyboardShortcut shortcut &&
                   Key == shortcut.Key &&
                   Modifier == shortcut.Modifier;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Modifier);
        }

        public static KeyboardShortcut None { get; } = new()
        {
            Key = Keys.None,
            Modifier = ModifierKeys.None
        };

        [Flags]
        public enum ModifierKeys : uint
        {
            None = 0,
            Control = 2,
            Windows = 8,
            Alt = 1,
            Shift = 4
        }

        public static bool operator ==(KeyboardShortcut left, KeyboardShortcut right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(KeyboardShortcut left, KeyboardShortcut right)
        {
            return !(left == right);
        }
    }
}
