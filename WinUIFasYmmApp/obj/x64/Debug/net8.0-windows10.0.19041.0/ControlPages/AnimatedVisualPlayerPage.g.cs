﻿#pragma checksum "C:\Users\sabri\Desktop\FasWebAPI\dev2ninovasyon\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\AnimatedVisualPlayerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "91964CA0855D0D5B1A0BA556DB9E11FB238581E0FF2B20AACF9BA5B2FAD0D4F6"
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
    partial class AnimatedVisualPlayerPage : 
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
            case 2: // ControlPages\AnimatedVisualPlayerPage.xaml line 13
                {
                    this.AnimatedVisualPlayerExample = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\AnimatedVisualPlayerPage.xaml line 66
                {
                    this.PlayButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.PlayButton).Click += this.PlayButton_Click;
                }
                break;
            case 4: // ControlPages\AnimatedVisualPlayerPage.xaml line 76
                {
                    this.PauseButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PauseButton).Checked += this.PauseButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PauseButton).Unchecked += this.PauseButton_Unchecked;
                }
                break;
            case 5: // ControlPages\AnimatedVisualPlayerPage.xaml line 88
                {
                    this.StopButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.StopButton).Click += this.StopButton_Click;
                }
                break;
            case 6: // ControlPages\AnimatedVisualPlayerPage.xaml line 98
                {
                    this.ReverseButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ReverseButton).Click += this.ReverseButton_Click;
                }
                break;
            case 7: // ControlPages\AnimatedVisualPlayerPage.xaml line 37
                {
                    this.Player = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer>(target);
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

