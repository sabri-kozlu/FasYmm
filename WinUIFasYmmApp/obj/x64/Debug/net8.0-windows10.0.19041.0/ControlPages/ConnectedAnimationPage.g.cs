﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\ConnectedAnimationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "778BD06868CB4E55D5E5D7756E9EA8F45E9F039A6FC9B381D743560D9D441970"
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
    partial class ConnectedAnimationPage : 
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
            case 1: // ControlPages\ConnectedAnimationPage.xaml line 1
                {
                    this.pageRoot = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Page>(target);
                }
                break;
            case 2: // ControlPages\ConnectedAnimationPage.xaml line 22
                {
                    global::Microsoft.UI.Xaml.Controls.Button element2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element2).Click += this.NavigateButton_Click;
                }
                break;
            case 3: // ControlPages\ConnectedAnimationPage.xaml line 25
                {
                    if (ConnectedAnimationPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_7)
                    {
                        this.ConfigurationPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButtons>(target);
                    }
                }
                break;
            case 4: // ControlPages\ConnectedAnimationPage.xaml line 33
                {
                    this.ContentFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 5: // ControlPages\ConnectedAnimationPage.xaml line 16
                {
                    this.CardFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 6: // ControlPages\ConnectedAnimationPage.xaml line 12
                {
                    this.CollectionContentFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
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
        internal static bool IsApiContractPresent_Windows_Foundation_UniversalApiContract_7 = global::Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
    }
}

