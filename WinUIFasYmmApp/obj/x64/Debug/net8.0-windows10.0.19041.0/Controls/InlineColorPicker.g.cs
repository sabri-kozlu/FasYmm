﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\Controls\InlineColorPicker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6DC49D8D47D094F60AB51B524284A829294994860BFF5B0C4FBA0BD3EF22F8F5"
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
    partial class InlineColorPicker : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Shapes_Shape_Fill(global::Microsoft.UI.Xaml.Shapes.Shape obj, global::Microsoft.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.Brush) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Fill = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class InlineColorPicker_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IInlineColorPicker_Bindings
        {
            private global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj2;
            private global::Microsoft.UI.Xaml.Shapes.Rectangle obj4;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2TextDisabled = false;
            private static bool isobj4FillDisabled = false;

            private InlineColorPicker_obj1_BindingsTracking bindingsTracking;

            public InlineColorPicker_obj1_Bindings()
            {
                this.bindingsTracking = new InlineColorPicker_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 27 && columnNumber == 13)
                {
                    isobj2TextDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 17)
                {
                    isobj4FillDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\InlineColorPicker.xaml line 19
                        this.obj2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 4: // Controls\InlineColorPicker.xaml line 33
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
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

            // IInlineColorPicker_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Header(obj.Header, phase);
                        this.Update_ColorBrush(obj.ColorBrush, phase);
                    }
                }
            }
            private void Update_Header(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\InlineColorPicker.xaml line 19
                    if (!isobj2TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ColorBrush(global::Microsoft.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\InlineColorPicker.xaml line 33
                    if (!isobj4FillDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Shapes_Shape_Fill(this.obj4, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class InlineColorPicker_obj1_BindingsTracking
            {
                private global::System.WeakReference<InlineColorPicker_obj1_Bindings> weakRefToBindingObj; 

                public InlineColorPicker_obj1_BindingsTracking(InlineColorPicker_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<InlineColorPicker_obj1_Bindings>(obj);
                }

                public InlineColorPicker_obj1_Bindings TryGetBindingObject()
                {
                    InlineColorPicker_obj1_Bindings bindingObject = null;
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

                public void DependencyPropertyChanged_Header(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    InlineColorPicker_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker obj = sender as global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker;
                        if (obj != null)
                        {
                            bindings.Update_Header(obj.Header, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ColorBrush(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    InlineColorPicker_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker obj = sender as global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker;
                        if (obj != null)
                        {
                            bindings.Update_ColorBrush(obj.ColorBrush, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Header = 0;
                private long tokenDPC_ColorBrush = 0;
                public void UpdateChildListeners_(global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker obj)
                {
                    InlineColorPicker_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker.HeaderProperty, tokenDPC_Header);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker.ColorBrushProperty, tokenDPC_ColorBrush);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Header = obj.RegisterPropertyChangedCallback(global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker.HeaderProperty, DependencyPropertyChanged_Header);
                            tokenDPC_ColorBrush = obj.RegisterPropertyChangedCallback(global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker.ColorBrushProperty, DependencyPropertyChanged_ColorBrush);
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
            case 2: // Controls\InlineColorPicker.xaml line 19
                {
                    this.HeaderText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 3: // Controls\InlineColorPicker.xaml line 49
                {
                    this.ColorHex = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBox)this.ColorHex).TextChanged += this.ColorHex_TextChanged;
                }
                break;
            case 4: // Controls\InlineColorPicker.xaml line 33
                {
                    this.ColorPreview = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 5: // Controls\InlineColorPicker.xaml line 40
                {
                    global::Microsoft.UI.Xaml.Controls.Flyout element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Flyout>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Flyout)element5).Opened += this.PickerFlyout_Opened;
                }
                break;
            case 6: // Controls\InlineColorPicker.xaml line 41
                {
                    this.Picker = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ColorPicker>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ColorPicker)this.Picker).ColorChanged += this.Picker_ColorChanged;
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
            case 1: // Controls\InlineColorPicker.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    InlineColorPicker_obj1_Bindings bindings = new InlineColorPicker_obj1_Bindings();
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
