﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\ControlPages\DesignGuidance\GeometryPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02E4D20EF7A8ACA84FD04ADA8BF8E0C18258DB4E51572A34861E29CFDAEBAE76"
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
    partial class GeometryPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(global::Microsoft.UI.Xaml.Controls.TeachingTip obj, global::Microsoft.UI.Xaml.FrameworkElement value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.FrameworkElement) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.FrameworkElement), targetNullValue);
                }
                obj.Target = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class GeometryPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IGeometryPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.GeometryPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj6;
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj8;
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6TargetDisabled = false;
            private static bool isobj8TargetDisabled = false;
            private static bool isobj10TargetDisabled = false;

            public GeometryPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 79 && columnNumber == 29)
                {
                    isobj6TargetDisabled = true;
                }
                else if (lineNumber == 96 && columnNumber == 29)
                {
                    isobj8TargetDisabled = true;
                }
                else if (lineNumber == 114 && columnNumber == 29)
                {
                    isobj10TargetDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // ControlPages\DesignGuidance\GeometryPage.xaml line 75
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                        break;
                    case 8: // ControlPages\DesignGuidance\GeometryPage.xaml line 93
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                        break;
                    case 10: // ControlPages\DesignGuidance\GeometryPage.xaml line 110
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IGeometryPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.GeometryPage>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WinUIFasYmmApp.ControlPages.GeometryPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ShowGeometryButton1(obj.ShowGeometryButton1, phase);
                        this.Update_ShowGeometryButton2(obj.ShowGeometryButton2, phase);
                        this.Update_ShowGeometryButton3(obj.ShowGeometryButton3, phase);
                    }
                }
            }
            private void Update_ShowGeometryButton1(global::Microsoft.UI.Xaml.Controls.Button obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\DesignGuidance\GeometryPage.xaml line 75
                    if (!isobj6TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ShowGeometryButton2(global::Microsoft.UI.Xaml.Controls.Button obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\DesignGuidance\GeometryPage.xaml line 93
                    if (!isobj8TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj8, obj, null);
                    }
                }
            }
            private void Update_ShowGeometryButton3(global::Microsoft.UI.Xaml.Controls.Button obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\DesignGuidance\GeometryPage.xaml line 110
                    if (!isobj10TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj10, obj, null);
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // ControlPages\DesignGuidance\GeometryPage.xaml line 13
                {
                    this.compactPage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Page>(target);
                }
                break;
            case 2: // ControlPages\DesignGuidance\GeometryPage.xaml line 47
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\DesignGuidance\GeometryPage.xaml line 209
                {
                    this.CopyControlResourceToClipboardButton = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.DesktopWap.Controls.CopyButton>(target);
                    ((global::WinUIFasYmmApp.DesktopWap.Controls.CopyButton)this.CopyControlResourceToClipboardButton).Click += this.CopyControlResourceToClipboardButton_Click;
                }
                break;
            case 4: // ControlPages\DesignGuidance\GeometryPage.xaml line 171
                {
                    this.CopyOverlayResourceToClipboardButton = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.DesktopWap.Controls.CopyButton>(target);
                    ((global::WinUIFasYmmApp.DesktopWap.Controls.CopyButton)this.CopyOverlayResourceToClipboardButton).Click += this.CopyOverlayResourceToClipboardButton_Click;
                }
                break;
            case 5: // ControlPages\DesignGuidance\GeometryPage.xaml line 64
                {
                    this.ShowGeometryButton1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ShowGeometryButton1).Click += this.ShowGeometryButtonClick1;
                }
                break;
            case 6: // ControlPages\DesignGuidance\GeometryPage.xaml line 75
                {
                    this.ShowGeometryInfoTooltip1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                }
                break;
            case 7: // ControlPages\DesignGuidance\GeometryPage.xaml line 82
                {
                    this.ShowGeometryButton2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ShowGeometryButton2).Click += this.ShowGeometryButtonClick2;
                }
                break;
            case 8: // ControlPages\DesignGuidance\GeometryPage.xaml line 93
                {
                    this.ShowGeometryInfoTooltip2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                }
                break;
            case 9: // ControlPages\DesignGuidance\GeometryPage.xaml line 99
                {
                    this.ShowGeometryButton3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ShowGeometryButton3).Click += this.ShowGeometryButtonClick3;
                }
                break;
            case 10: // ControlPages\DesignGuidance\GeometryPage.xaml line 110
                {
                    this.ShowGeometryInfoTooltip3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
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
            switch(connectionId)
            {
            case 1: // ControlPages\DesignGuidance\GeometryPage.xaml line 13
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    GeometryPage_obj1_Bindings bindings = new GeometryPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
