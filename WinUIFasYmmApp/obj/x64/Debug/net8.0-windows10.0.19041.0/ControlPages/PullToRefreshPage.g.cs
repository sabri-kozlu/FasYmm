﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\PullToRefreshPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "583BB7BAFD8883EABF7ADC96E9FD9CF3E3CD51B04EAAAD0CCD2435187485FA06"
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
    partial class PullToRefreshPage : 
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
            case 2: // ControlPages\PullToRefreshPage.xaml line 13
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\PullToRefreshPage.xaml line 56
                {
                    this.Example2 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 4: // ControlPages\PullToRefreshPage.xaml line 58
                {
                    this.Ex2Grid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 5: // ControlPages\PullToRefreshPage.xaml line 16
                {
                    if (PullToRefreshPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_6)
                    {
                        this.rc = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RefreshContainer>(target);
                        if (PullToRefreshPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_6)
                        {
                            ((global::Microsoft.UI.Xaml.Controls.RefreshContainer)this.rc).RefreshRequested += this.rc_RefreshRequested;
                        }
                    }
                }
                break;
            case 6: // ControlPages\PullToRefreshPage.xaml line 17
                {
                    if (PullToRefreshPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_6)
                    {
                        this.lv = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                    }
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

        // Api Information for conditional namespace declarations
        internal static bool IsApiContractPresent_Windows_Foundation_UniversalApiContract_6 = global::Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 6);
    }
}

