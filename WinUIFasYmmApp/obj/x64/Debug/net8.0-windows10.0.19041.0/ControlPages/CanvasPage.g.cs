﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\ControlPages\CanvasPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "013FCC04B5B5A87AEECCB8FE298A437C9DD305B381EC7ADF1E1E08B211383913"
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
    partial class CanvasPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Canvas_Left(global::Microsoft.UI.Xaml.UIElement obj, global::System.Double value)
            {
                global::Microsoft.UI.Xaml.Controls.Canvas.SetLeft(obj, value);
            }
            public static void Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(global::WinUIFasYmmApp.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Canvas_Top(global::Microsoft.UI.Xaml.UIElement obj, global::System.Double value)
            {
                global::Microsoft.UI.Xaml.Controls.Canvas.SetTop(obj, value);
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Canvas_ZIndex(global::Microsoft.UI.Xaml.UIElement obj, global::System.Int32 value)
            {
                global::Microsoft.UI.Xaml.Controls.Canvas.SetZIndex(obj, value);
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class CanvasPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ICanvasPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.CanvasPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Shapes.Rectangle obj4;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj8;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj9;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4LeftDisabled = false;
            private static bool isobj4TopDisabled = false;
            private static bool isobj4ZIndexDisabled = false;
            private static bool isobj8ValueDisabled = false;
            private static bool isobj9ValueDisabled = false;
            private static bool isobj10ValueDisabled = false;

            private CanvasPage_obj1_BindingsTracking bindingsTracking;

            public CanvasPage_obj1_Bindings()
            {
                this.bindingsTracking = new CanvasPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 26 && columnNumber == 39)
                {
                    isobj4LeftDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 25)
                {
                    isobj4TopDisabled = true;
                }
                else if (lineNumber == 28 && columnNumber == 25)
                {
                    isobj4ZIndexDisabled = true;
                }
                else if (lineNumber == 59 && columnNumber == 62)
                {
                    isobj8ValueDisabled = true;
                }
                else if (lineNumber == 60 && columnNumber == 61)
                {
                    isobj9ValueDisabled = true;
                }
                else if (lineNumber == 61 && columnNumber == 59)
                {
                    isobj10ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // ControlPages\CanvasPage.xaml line 26
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                        break;
                    case 8: // ControlPages\CanvasPage.xaml line 59
                        this.obj8 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                        break;
                    case 9: // ControlPages\CanvasPage.xaml line 60
                        this.obj9 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                        break;
                    case 10: // ControlPages\CanvasPage.xaml line 61
                        this.obj10 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
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

            // ICanvasPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.CanvasPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.CanvasPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_LeftSlider(obj.LeftSlider, phase);
                        this.Update_TopSlider(obj.TopSlider, phase);
                        this.Update_ZSlider(obj.ZSlider, phase);
                    }
                }
            }
            private void Update_LeftSlider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_LeftSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_LeftSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_LeftSlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CanvasPage.xaml line 26
                    if (!isobj4LeftDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Canvas_Left(this.obj4, obj);
                    }
                    // ControlPages\CanvasPage.xaml line 59
                    if (!isobj8ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj8, obj, null);
                    }
                }
            }
            private void Update_TopSlider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_TopSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_TopSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_TopSlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CanvasPage.xaml line 26
                    if (!isobj4TopDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Canvas_Top(this.obj4, obj);
                    }
                    // ControlPages\CanvasPage.xaml line 60
                    if (!isobj9ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj9, obj, null);
                    }
                }
            }
            private void Update_ZSlider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ZSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ZSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_ZSlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_ZSlider_Value_Cast_Value_To_Int32((global::System.Int32)obj, phase);
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CanvasPage.xaml line 61
                    if (!isobj10ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj10, obj, null);
                    }
                }
            }
            private void Update_ZSlider_Value_Cast_Value_To_Int32(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CanvasPage.xaml line 26
                    if (!isobj4ZIndexDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Canvas_ZIndex(this.obj4, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CanvasPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<CanvasPage_obj1_Bindings> weakRefToBindingObj; 

                public CanvasPage_obj1_BindingsTracking(CanvasPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CanvasPage_obj1_Bindings>(obj);
                }

                public CanvasPage_obj1_Bindings TryGetBindingObject()
                {
                    CanvasPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_LeftSlider(null);
                    UpdateChildListeners_TopSlider(null);
                    UpdateChildListeners_ZSlider(null);
                }

                public void DependencyPropertyChanged_LeftSlider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    CanvasPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_LeftSlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_LeftSlider = null;
                private long tokenDPC_LeftSlider_Value = 0;
                public void UpdateChildListeners_LeftSlider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_LeftSlider)
                    {
                        if (cache_LeftSlider != null)
                        {
                            cache_LeftSlider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_LeftSlider_Value);
                            cache_LeftSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_LeftSlider = obj;
                            tokenDPC_LeftSlider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_LeftSlider_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_TopSlider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    CanvasPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_TopSlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_TopSlider = null;
                private long tokenDPC_TopSlider_Value = 0;
                public void UpdateChildListeners_TopSlider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_TopSlider)
                    {
                        if (cache_TopSlider != null)
                        {
                            cache_TopSlider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_TopSlider_Value);
                            cache_TopSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_TopSlider = obj;
                            tokenDPC_TopSlider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_TopSlider_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_ZSlider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    CanvasPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_ZSlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_ZSlider = null;
                private long tokenDPC_ZSlider_Value = 0;
                public void UpdateChildListeners_ZSlider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_ZSlider)
                    {
                        if (cache_ZSlider != null)
                        {
                            cache_ZSlider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_ZSlider_Value);
                            cache_ZSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_ZSlider = obj;
                            tokenDPC_ZSlider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_ZSlider_Value);
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
            case 2: // ControlPages\CanvasPage.xaml line 17
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\CanvasPage.xaml line 19
                {
                    this.Control1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Canvas>(target);
                }
                break;
            case 5: // ControlPages\CanvasPage.xaml line 36
                {
                    this.TopSlider = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Slider>(target);
                }
                break;
            case 6: // ControlPages\CanvasPage.xaml line 42
                {
                    this.LeftSlider = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Slider>(target);
                }
                break;
            case 7: // ControlPages\CanvasPage.xaml line 44
                {
                    this.ZSlider = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Slider>(target);
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
            case 1: // ControlPages\CanvasPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    CanvasPage_obj1_Bindings bindings = new CanvasPage_obj1_Bindings();
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

