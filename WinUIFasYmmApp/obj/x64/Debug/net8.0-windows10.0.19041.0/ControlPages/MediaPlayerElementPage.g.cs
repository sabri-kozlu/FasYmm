﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\MediaPlayerElementPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D90FF07F1F5A770B56B48F90FB0AB4DC35DE1DF6C8AF50E54FDCC33899411931"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUIFasYmmApp.ControlPages
{
    partial class MediaPlayerElementPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // ControlPages\MediaPlayerElementPage.xaml line 7
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\MediaPlayerElementPage.xaml line 21
                {
                    this.Example2 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 4: // ControlPages\MediaPlayerElementPage.xaml line 23
                {
                    this.Player2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MediaPlayerElement>(target);
                }
                break;
            case 5: // ControlPages\MediaPlayerElementPage.xaml line 9
                {
                    this.Player1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MediaPlayerElement>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }


        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

