﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\NumberBoxPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70770D115AEA1CDC2B935E4E93D3AB72FBA99071226EC1637A995BB17E6E5127"
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
    partial class NumberBoxPage : 
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
            case 2: // ControlPages\NumberBoxPage.xaml line 58
                {
                    this.FormattedNumberBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                }
                break;
            case 3: // ControlPages\NumberBoxPage.xaml line 36
                {
                    this.NumberBoxSpinButtonPlacementExample = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                }
                break;
            case 4: // ControlPages\NumberBoxPage.xaml line 47
                {
                    this.SpinButtonPlacementGroup = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButtons>(target);
                }
                break;
            case 5: // ControlPages\NumberBoxPage.xaml line 48
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element5).Checked += this.RadioButton_Checked;
                }
                break;
            case 6: // ControlPages\NumberBoxPage.xaml line 49
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element6).Checked += this.RadioButton_Checked;
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

