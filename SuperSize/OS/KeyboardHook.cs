using System;
using System.Windows.Forms;
using Windows.Win32;
using static SuperSize.Model.KeyboardShortcut;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Input.KeyboardAndMouse;
using System.ComponentModel;

namespace SuperSize.OS;

public sealed class KeyboardHook : IDisposable
{
    private Window _window = new();
    private int _currentId;

    public KeyboardHook()
    {
        // register the event of the inner native window.
        _window.KeyPressed += (sender, args) =>
        {
            KeyPressed?.Invoke(this, args);
        };
    }

    /// <summary>
    /// Registers a hot key in the system.
    /// </summary>
    /// <param name="modifier">The modifiers that are associated with the hot key.</param>
    /// <param name="key">The key itself that is associated with the hot key.</param>
    public void RegisterHotKey(ModifierKeys modifier, Keys key)
    {
        // increment the counter.
        _currentId = _currentId + 1;

        // register the hot key.
        if (!PInvoke.RegisterHotKey(new HWND( _window.Handle), _currentId, (HOT_KEY_MODIFIERS)modifier, (uint)key))
        {
            // roll back as it wasn't actually set
            _currentId = _currentId - 1;
            throw new HookRegistrationException();
        }
    }

    /// <summary>
    /// A hot key has been pressed.
    /// </summary>
    public event EventHandler<KeyPressedEventArgs>? KeyPressed;

    public void Dispose()
    {
        // unregister all the registered hot keys.
        for (int i = _currentId; i > 0; i--)
        {
            PInvoke.UnregisterHotKey(new HWND(_window.Handle), i);
        }

        // dispose the inner native window.
        _window.Dispose();
    }

    private class Window : NativeWindow, IDisposable
    {
        private const int WM_HOTKEY = 0x0312;

        public Window()
        {
            // create the handle for the window.
            CreateHandle(new CreateParams());
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // check if we got a hot key pressed.
            if (m.Msg == WM_HOTKEY)
            {
                // get the keys.
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

                // invoke the event to notify the parent.
                KeyPressed?.Invoke(this, new KeyPressedEventArgs(modifier, key));
            }
        }

        public event EventHandler<KeyPressedEventArgs>? KeyPressed;

        public void Dispose()
        {
            DestroyHandle();
        }
    }
}

/// <summary>
/// Event Args for the event that is fired after the hot key has been pressed.
/// </summary>
public class KeyPressedEventArgs : EventArgs
{
    private ModifierKeys _modifier;
    private Keys _key;

    internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
    {
        _modifier = modifier;
        _key = key;
    }

    public ModifierKeys Modifier
    {
        get { return _modifier; }
    }

    public Keys Key
    {
        get { return _key; }
    }
}
