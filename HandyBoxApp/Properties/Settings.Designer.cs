﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandyBoxApp.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public double Transparency
        {
            get
            {
                return ((double)(this["Transparency"]));
            }
            set
            {
                this["Transparency"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OnTop
        {
            get
            {
                return ((bool)(this["OnTop"]));
            }
            set
            {
                this["OnTop"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point LastLocation
        {
            get
            {
                return ((global::System.Drawing.Point)(this["LastLocation"]));
            }
            set
            {
                this["LastLocation"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection Stocks
        {
            get
            {
                return ((global::System.Collections.Specialized.StringCollection)(this["Stocks"]));
            }
            set
            {
                this["Stocks"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime StartTime
        {
            get
            {
                return ((global::System.DateTime)(this["StartTime"]));
            }
            set
            {
                this["StartTime"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Elapsed")]
        public global::HandyBoxApp.WorkTimer.FunctionMode ModeFunction
        {
            get
            {
                return ((global::HandyBoxApp.WorkTimer.FunctionMode)(this["ModeFunction"]));
            }
            set
            {
                this["ModeFunction"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Stopped")]
        public global::HandyBoxApp.WorkTimer.TimerMode ModeTimer
        {
            get
            {
                return ((global::HandyBoxApp.WorkTimer.TimerMode)(this["ModeTimer"]));
            }
            set
            {
                this["ModeTimer"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00")]
        public global::System.TimeSpan PauseTime
        {
            get
            {
                return ((global::System.TimeSpan)(this["PauseTime"]));
            }
            set
            {
                this["PauseTime"] = value;
            }
        }
    }
}
