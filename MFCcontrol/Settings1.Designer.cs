﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFCcontrol {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    public sealed partial class Settings1 : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings1 defaultInstance = ((Settings1)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings1())));
        
        public static Settings1 Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int ADacquireTime_ms {
            get {
                return ((int)(this["ADacquireTime_ms"]));
            }
            set {
                this["ADacquireTime_ms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int timerUI_ms {
            get {
                return ((int)(this["timerUI_ms"]));
            }
            set {
                this["timerUI_ms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int MFCcontrol_numMFCs {
            get {
                return ((int)(this["MFCcontrol_numMFCs"]));
            }
            set {
                this["MFCcontrol_numMFCs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Dev1/ai0,Dev1/ai1,Dev1/ai2,Dev1/ai3")]
        public string DAQ_CreateVoltageChannel_AI_chans {
            get {
                return ((string)(this["DAQ_CreateVoltageChannel_AI_chans"]));
            }
            set {
                this["DAQ_CreateVoltageChannel_AI_chans"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int ADoutRefreshTime_ms {
            get {
                return ((int)(this["ADoutRefreshTime_ms"]));
            }
            set {
                this["ADoutRefreshTime_ms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MFC1enable {
            get {
                return ((bool)(this["MFC1enable"]));
            }
            set {
                this["MFC1enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MFC2enable {
            get {
                return ((bool)(this["MFC2enable"]));
            }
            set {
                this["MFC2enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public string MFC1maxRange {
            get {
                return ((string)(this["MFC1maxRange"]));
            }
            set {
                this["MFC1maxRange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public string MFC2maxRange {
            get {
                return ((string)(this["MFC2maxRange"]));
            }
            set {
                this["MFC2maxRange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Air")]
        public string MFC1Gas {
            get {
                return ((string)(this["MFC1Gas"]));
            }
            set {
                this["MFC1Gas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Analyte1")]
        public string MFC2Gas {
            get {
                return ((string)(this["MFC2Gas"]));
            }
            set {
                this["MFC2Gas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MFC1PlotEnable {
            get {
                return ((bool)(this["MFC1PlotEnable"]));
            }
            set {
                this["MFC1PlotEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MFC2PlotEnable {
            get {
                return ((bool)(this["MFC2PlotEnable"]));
            }
            set {
                this["MFC2PlotEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int GraphTimeUpdateMS {
            get {
                return ((int)(this["GraphTimeUpdateMS"]));
            }
            set {
                this["GraphTimeUpdateMS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int SamplesToGraphReset {
            get {
                return ((int)(this["SamplesToGraphReset"]));
            }
            set {
                this["SamplesToGraphReset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Analyte2")]
        public string MFC3Gas {
            get {
                return ((string)(this["MFC3Gas"]));
            }
            set {
                this["MFC3Gas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Analyte3")]
        public string MFC4Gas {
            get {
                return ((string)(this["MFC4Gas"]));
            }
            set {
                this["MFC4Gas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MFC3PlotEnable {
            get {
                return ((bool)(this["MFC3PlotEnable"]));
            }
            set {
                this["MFC3PlotEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MFC4PlotEnable {
            get {
                return ((bool)(this["MFC4PlotEnable"]));
            }
            set {
                this["MFC4PlotEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public string MFC3maxRange {
            get {
                return ((string)(this["MFC3maxRange"]));
            }
            set {
                this["MFC3maxRange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public string MFC4maxRange {
            get {
                return ((string)(this["MFC4maxRange"]));
            }
            set {
                this["MFC4maxRange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MFC3enable {
            get {
                return ((bool)(this["MFC3enable"]));
            }
            set {
                this["MFC3enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MFC4enable {
            get {
                return ((bool)(this["MFC4enable"]));
            }
            set {
                this["MFC4enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PicoammeterControlEnable {
            get {
                return ((bool)(this["PicoammeterControlEnable"]));
            }
            set {
                this["PicoammeterControlEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool mfcMainControlEnable {
            get {
                return ((bool)(this["mfcMainControlEnable"]));
            }
            set {
                this["mfcMainControlEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Dev2/ao0")]
        public string sensorVdsDaqAO {
            get {
                return ((string)(this["sensorVdsDaqAO"]));
            }
            set {
                this["sensorVdsDaqAO"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Dev2/ao1")]
        public string sensorVgsDaqAO {
            get {
                return ((string)(this["sensorVgsDaqAO"]));
            }
            set {
                this["sensorVgsDaqAO"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool sensorBiasEnable {
            get {
                return ((bool)(this["sensorBiasEnable"]));
            }
            set {
                this["sensorBiasEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool sensorVdsDaqLock {
            get {
                return ((bool)(this["sensorVdsDaqLock"]));
            }
            set {
                this["sensorVdsDaqLock"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool sensorVgsDaqLock {
            get {
                return ((bool)(this["sensorVgsDaqLock"]));
            }
            set {
                this["sensorVgsDaqLock"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double sensorBiasMaxRange {
            get {
                return ((double)(this["sensorBiasMaxRange"]));
            }
            set {
                this["sensorBiasMaxRange"] = value;
            }
        }
    }
}
