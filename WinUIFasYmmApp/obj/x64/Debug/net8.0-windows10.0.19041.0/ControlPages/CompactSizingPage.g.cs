﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\CompactSizingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01F099F031A8B5B41E0640281CF2F8A74A9217B584A1B669B8A590768883EA51"
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
    partial class CompactSizingPage : 
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
            case 1: // ControlPages\CompactSizingPage.xaml line 13
                {
                    this.compactPage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Page>(target);
                }
                break;
            case 2: // ControlPages\CompactSizingPage.xaml line 24
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                    ((global::WinUIFasYmmApp.ControlExample)this.Example1).Loaded += this.Example1_Loaded;
                }
                break;
            case 3: // ControlPages\CompactSizingPage.xaml line 25
                {
                    this.ContentFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 4: // ControlPages\CompactSizingPage.xaml line 29
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element4).Checked += this.Standard_Checked;
                }
                break;
            case 5: // ControlPages\CompactSizingPage.xaml line 30
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element5).Checked += this.Compact_Checked;
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

