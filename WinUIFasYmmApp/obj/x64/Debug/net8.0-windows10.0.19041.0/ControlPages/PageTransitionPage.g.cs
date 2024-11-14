﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\PageTransitionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB742398B61515016C6866BD81913B2AA904A3AF465EB41D96963B89B4EBC5E5"
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
    partial class PageTransitionPage : 
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
            case 1: // ControlPages\PageTransitionPage.xaml line 1
                {
                    this.pageRoot = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Page>(target);
                }
                break;
            case 2: // ControlPages\PageTransitionPage.xaml line 13
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\PageTransitionPage.xaml line 26
                {
                    global::Microsoft.UI.Xaml.Controls.Button element3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element3).Click += this.ForwardButton1_Click;
                }
                break;
            case 4: // ControlPages\PageTransitionPage.xaml line 27
                {
                    global::Microsoft.UI.Xaml.Controls.Button element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element4).Click += this.BackwardButton1_Click;
                }
                break;
            case 5: // ControlPages\PageTransitionPage.xaml line 17
                {
                    this.DefaultRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)this.DefaultRB).Checked += this.TransitionRadioButton_Checked;
                }
                break;
            case 6: // ControlPages\PageTransitionPage.xaml line 18
                {
                    this.EntranceRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)this.EntranceRB).Checked += this.TransitionRadioButton_Checked;
                }
                break;
            case 7: // ControlPages\PageTransitionPage.xaml line 19
                {
                    this.DrillRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)this.DrillRB).Checked += this.TransitionRadioButton_Checked;
                }
                break;
            case 8: // ControlPages\PageTransitionPage.xaml line 20
                {
                    this.SuppressRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)this.SuppressRB).Checked += this.TransitionRadioButton_Checked;
                }
                break;
            case 9: // ControlPages\PageTransitionPage.xaml line 21
                {
                    if (PageTransitionPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_7)
                    {
                        this.SlideFromRightRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                        if (PageTransitionPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_7)
                        {
                            ((global::Microsoft.UI.Xaml.Controls.RadioButton)this.SlideFromRightRB).Checked += this.TransitionRadioButton_Checked;
                        }
                    }
                }
                break;
            case 10: // ControlPages\PageTransitionPage.xaml line 22
                {
                    if (PageTransitionPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_7)
                    {
                        this.SlideFromLeftRB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                        if (PageTransitionPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_7)
                        {
                            ((global::Microsoft.UI.Xaml.Controls.RadioButton)this.SlideFromLeftRB).Checked += this.TransitionRadioButton_Checked;
                        }
                    }
                }
                break;
            case 11: // ControlPages\PageTransitionPage.xaml line 31
                {
                    this.ContentFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 12: // ControlPages\PageTransitionPage.xaml line 56
                {
                    this.TransitionValue = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
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

