﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperSize.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.13.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("27")]
        public uint ShortcutKey {
            get {
                return ((uint)(this["ShortcutKey"]));
            }
            set {
                this["ShortcutKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public uint ShortcutModifier {
            get {
                return ((uint)(this["ShortcutModifier"]));
            }
            set {
                this["ShortcutModifier"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("45, 125, 154")]
        public global::System.Drawing.Color ScreenBorderColor {
            get {
                return ((global::System.Drawing.Color)(this["ScreenBorderColor"]));
            }
            set {
                this["ScreenBorderColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("238, 238, 238")]
        public global::System.Drawing.Color ScreenFillColor {
            get {
                return ((global::System.Drawing.Color)(this["ScreenFillColor"]));
            }
            set {
                this["ScreenFillColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("224, 224, 224")]
        public global::System.Drawing.Color PrimaryScreenFillColor {
            get {
                return ((global::System.Drawing.Color)(this["PrimaryScreenFillColor"]));
            }
            set {
                this["PrimaryScreenFillColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ScreenTextColor {
            get {
                return ((global::System.Drawing.Color)(this["ScreenTextColor"]));
            }
            set {
                this["ScreenTextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Segoe UI, 9pt, style=Bold")]
        public global::System.Drawing.Font ScreenTextFontFamily {
            get {
                return ((global::System.Drawing.Font)(this["ScreenTextFontFamily"]));
            }
            set {
                this["ScreenTextFontFamily"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("232, 17, 35")]
        public global::System.Drawing.Color WindowPreviewBorder {
            get {
                return ((global::System.Drawing.Color)(this["WindowPreviewBorder"]));
            }
            set {
                this["WindowPreviewBorder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WasOnboarded {
            get {
                return ((bool)(this["WasOnboarded"]));
            }
            set {
                this["WasOnboarded"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SuperSize.CoreLogic.UseAllScreen")]
        public string LogicClass {
            get {
                return ((string)(this["LogicClass"]));
            }
            set {
                this["LogicClass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogicConfig {
            get {
                return ((string)(this["LogicConfig"]));
            }
            set {
                this["LogicConfig"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogicSettings {
            get {
                return ((string)(this["LogicSettings"]));
            }
            set {
                this["LogicSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ResizeNonResizableAnyway {
            get {
                return ((bool)(this["ResizeNonResizableAnyway"]));
            }
            set {
                this["ResizeNonResizableAnyway"] = value;
            }
        }
    }
}
