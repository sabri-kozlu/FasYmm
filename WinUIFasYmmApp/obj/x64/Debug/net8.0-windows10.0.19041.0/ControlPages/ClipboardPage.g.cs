﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\ControlPages\ClipboardPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7134429638393045DD43A9E74BF361BD318981216732555E97FDB11BA73760B9"
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
    partial class ClipboardPage : 
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
            case 2: // ControlPages\ClipboardPage.xaml line 21
                {
                    this.ConfirmClipboardGroups = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualStateGroup>(target);
                }
                break;
            case 3: // ControlPages\ClipboardPage.xaml line 22
                {
                    this.ConfirmationClipboardCollapsed = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 4: // ControlPages\ClipboardPage.xaml line 27
                {
                    this.ConfirmationClipboardVisible = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 5: // ControlPages\ClipboardPage.xaml line 36
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 6: // ControlPages\ClipboardPage.xaml line 70
                {
                    this.Example2 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 7: // ControlPages\ClipboardPage.xaml line 72
                {
                    global::Microsoft.UI.Xaml.Controls.Button element7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element7).Click += this.PasteText_Click;
                }
                break;
            case 8: // ControlPages\ClipboardPage.xaml line 74
                {
                    this.PasteClipboard1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 9: // ControlPages\ClipboardPage.xaml line 77
                {
                    this.PasteClipboard2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 10: // ControlPages\ClipboardPage.xaml line 45
                {
                    this.richEditBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RichEditBox>(target);
                }
                break;
            case 11: // ControlPages\ClipboardPage.xaml line 40
                {
                    global::Microsoft.UI.Xaml.Controls.Button element11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element11).Click += this.CopyText_Click;
                }
                break;
            case 12: // ControlPages\ClipboardPage.xaml line 42
                {
                    this.ConfirmationTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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
