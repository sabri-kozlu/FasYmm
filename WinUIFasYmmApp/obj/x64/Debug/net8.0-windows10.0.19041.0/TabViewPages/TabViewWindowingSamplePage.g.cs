﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\TabViewPages\TabViewWindowingSamplePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C5D00D688CFC7360375BCBC66572E7817AF73D464C77F4EDF11B8AA432F34575"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUIFasYmmApp.TabViewPages
{
    partial class TabViewWindowingSamplePage : 
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
            case 2: // TabViewPages\TabViewWindowingSamplePage.xaml line 12
                {
                    this.Tabs = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TabView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).AddTabButtonClick += this.Tabs_AddTabButtonClick;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabCloseRequested += this.Tabs_TabCloseRequested;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabTearOutWindowRequested += this.Tabs_TabTearOutWindowRequested;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).TabTearOutRequested += this.Tabs_TabTearOutRequested;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).ExternalTornOutTabsDropping += this.Tabs_ExternalTornOutTabsDropping;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)this.Tabs).ExternalTornOutTabsDropped += this.Tabs_ExternalTornOutTabsDropped;
                }
                break;
            case 3: // TabViewPages\TabViewWindowingSamplePage.xaml line 22
                {
                    this.ShellTitleBarInset = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 4: // TabViewPages\TabViewWindowingSamplePage.xaml line 25
                {
                    this.CustomDragRegion = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
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

