﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\Controls\HomePageHeaderImage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F857557E23BA878FFC9A23973E58F304BFF562CC70337FB0033933C5AD3E308A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUIFasYmmApp.Controls
{
    partial class HomePageHeaderImage : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
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
            case 1: // Controls\HomePageHeaderImage.xaml line 4
                {
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.UserControl>(target);
                    ((global::Microsoft.UI.Xaml.Controls.UserControl)element1).Loaded += this.OnLoaded;
                    ((global::Microsoft.UI.Xaml.Controls.UserControl)element1).Loading += this.OnLoading;
                    ((global::Microsoft.UI.Xaml.Controls.UserControl)element1).Unloaded += this.OnUnloaded;
                }
                break;
            case 2: // Controls\HomePageHeaderImage.xaml line 19
                {
                    this.BackgroundGradient = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Media.LinearGradientBrush>(target);
                }
                break;
            case 3: // Controls\HomePageHeaderImage.xaml line 37
                {
                    this.ImageGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 4: // Controls\HomePageHeaderImage.xaml line 55
                {
                    this.ImageGridSurfaceRec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 5: // Controls\HomePageHeaderImage.xaml line 41
                {
                    this.HeroImage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Image)this.HeroImage).ImageOpened += this.OnImageOpened;
                }
                break;
            case 6: // Controls\HomePageHeaderImage.xaml line 48
                {
                    this.HeroOverlayImage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
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

