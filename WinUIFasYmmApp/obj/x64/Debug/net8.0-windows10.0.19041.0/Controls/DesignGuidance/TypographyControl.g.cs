﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\Controls\DesignGuidance\TypographyControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "19742657077D740F6EB161248BE480663921896CE0431DD7D74ECD3ECE48FFB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUIFasYmmApp.DesktopWap.Controls
{
    partial class TypographyControl : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Panel_Background(global::Microsoft.UI.Xaml.Controls.Panel obj, global::Microsoft.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.Brush) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Microsoft_UI_Xaml_FrameworkElement_Style(global::Microsoft.UI.Xaml.FrameworkElement obj, global::Microsoft.UI.Xaml.Style value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Style) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Style), targetNullValue);
                }
                obj.Style = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class TypographyControl_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ITypographyControl_Bindings
        {
            private global::WinUIFasYmmApp.DesktopWap.Controls.TypographyControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.Grid obj2;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj3;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj4;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj5;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj6;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2BackgroundDisabled = false;
            private static bool isobj3StyleDisabled = false;
            private static bool isobj3TextDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;

            private TypographyControl_obj1_BindingsTracking bindingsTracking;

            public TypographyControl_obj1_Bindings()
            {
                this.bindingsTracking = new TypographyControl_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 13)
                {
                    isobj2BackgroundDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 17)
                {
                    isobj3StyleDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 17)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 17)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 17)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 49 && columnNumber == 17)
                {
                    isobj6TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\DesignGuidance\TypographyControl.xaml line 14
                        this.obj2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                        break;
                    case 3: // Controls\DesignGuidance\TypographyControl.xaml line 26
                        this.obj3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 4: // Controls\DesignGuidance\TypographyControl.xaml line 31
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 5: // Controls\DesignGuidance\TypographyControl.xaml line 36
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 6: // Controls\DesignGuidance\TypographyControl.xaml line 43
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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

            // ITypographyControl_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.DesktopWap.Controls.TypographyControl>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.DesktopWap.Controls.TypographyControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Background(obj.Background, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ExampleStyle(obj.ExampleStyle, phase);
                        this.Update_Example(obj.Example, phase);
                        this.Update_VariableFont(obj.VariableFont, phase);
                        this.Update_SizeLinHeight(obj.SizeLinHeight, phase);
                        this.Update_ResourceName(obj.ResourceName, phase);
                    }
                }
            }
            private void Update_Background(global::Microsoft.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\DesignGuidance\TypographyControl.xaml line 14
                    if (!isobj2BackgroundDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Panel_Background(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ExampleStyle(global::Microsoft.UI.Xaml.Style obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\DesignGuidance\TypographyControl.xaml line 26
                    if (!isobj3StyleDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Style(this.obj3, obj, null);
                    }
                }
            }
            private void Update_Example(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\DesignGuidance\TypographyControl.xaml line 26
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_VariableFont(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\DesignGuidance\TypographyControl.xaml line 31
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_SizeLinHeight(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\DesignGuidance\TypographyControl.xaml line 36
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ResourceName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\DesignGuidance\TypographyControl.xaml line 43
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class TypographyControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<TypographyControl_obj1_Bindings> weakRefToBindingObj; 

                public TypographyControl_obj1_BindingsTracking(TypographyControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<TypographyControl_obj1_Bindings>(obj);
                }

                public TypographyControl_obj1_Bindings TryGetBindingObject()
                {
                    TypographyControl_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_Background(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    TypographyControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.DesktopWap.Controls.TypographyControl obj = sender as global::WinUIFasYmmApp.DesktopWap.Controls.TypographyControl;
                        if (obj != null)
                        {
                            bindings.Update_Background(obj.Background, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Background = 0;
                public void UpdateChildListeners_(global::WinUIFasYmmApp.DesktopWap.Controls.TypographyControl obj)
                {
                    TypographyControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Control.BackgroundProperty, tokenDPC_Background);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Background = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Control.BackgroundProperty, DependencyPropertyChanged_Background);
                        }
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
            case 7: // Controls\DesignGuidance\TypographyControl.xaml line 50
                {
                    this.CopyToClipboardButton = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.DesktopWap.Controls.CopyButton>(target);
                    ((global::WinUIFasYmmApp.DesktopWap.Controls.CopyButton)this.CopyToClipboardButton).Click += this.CopyToClipboardButton_Click;
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
            case 1: // Controls\DesignGuidance\TypographyControl.xaml line 4
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    TypographyControl_obj1_Bindings bindings = new TypographyControl_obj1_Bindings();
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

