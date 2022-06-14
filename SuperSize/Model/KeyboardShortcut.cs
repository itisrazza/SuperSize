using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.Model
{
    /// <summary>
    /// Defines a keyboard shortcut.
    /// </summary>
    public struct KeyboardShortcut : IEquatable<KeyboardShortcut>
    {
        /// <summary>
        /// Shortcut key.
        /// </summary>
        public Keys Key { get; set; }

        /// <summary>
        /// Shortcut modifiers.
        /// </summary>
        public ModifierKeys Modifier { get; set; }

        /// <summary>
        /// Whether the shortcut is valid and should be applied.
        /// </summary>
        public bool IsInvalid => Key == Keys.None || Modifier == ModifierKeys.None;

        public KeyboardShortcut(Keys keys, ModifierKeys modifier)
        {
            Key = keys;
            Modifier = modifier;
        }

        /// <summary>
        /// A keyboard shortcut indicating no shortcut.
        /// </summary>
        public static KeyboardShortcut None { get; } = new()
        {
            Key = Keys.None,
            Modifier = ModifierKeys.None
        };

        /// <summary>
        /// Available modifier keys.
        /// </summary>
        [Flags]
        public enum ModifierKeys : uint
        {
            None = 0,
            Control = 2,
            Windows = 8,
            Alt = 1,
            Shift = 4
        }

        /// <summary>
        /// String representation for the keyboard shortcut.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Key == Keys.None || Modifier == ModifierKeys.None)
                return "(none)";

            var sb = new StringBuilder();
            foreach (var mod in Enum.GetValues<ModifierKeys>())
            {
                if (mod == ModifierKeys.None) continue;
                if ((Modifier & mod) == mod)
                {
                    if (sb.Length > 0) sb.Append(" + ");
                    sb.Append(mod);
                }
            }
            return sb.Append(" + ").Append(Key).ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is KeyboardShortcut shortcut &&
                   Key == shortcut.Key &&
                   Modifier == shortcut.Modifier;
        }

        public bool Equals(KeyboardShortcut other) => Equals((object)other);

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Modifier);
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
