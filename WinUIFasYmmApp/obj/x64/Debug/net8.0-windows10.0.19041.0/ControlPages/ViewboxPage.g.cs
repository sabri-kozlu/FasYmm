﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\ViewboxPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1211D91BE994402CCAA9A55B95487861702384CE9876BF37DFA9719A2EFCA363"
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
    partial class ViewboxPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_FrameworkElement_Height(global::Microsoft.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Height = value;
            }
            public static void Set_Microsoft_UI_Xaml_FrameworkElement_Width(global::Microsoft.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Width = value;
            }
            public static void Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(global::WinUIFasYmmApp.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class ViewboxPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IViewboxPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.ViewboxPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.Viewbox obj3;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj12;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj13;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj14;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3HeightDisabled = false;
            private static bool isobj3WidthDisabled = false;
            private static bool isobj12ValueDisabled = false;
            private static bool isobj13ValueDisabled = false;
            private static bool isobj14ValueDisabled = false;

            private ViewboxPage_obj1_BindingsTracking bindingsTracking;

            public ViewboxPage_obj1_Bindings()
            {
                this.bindingsTracking = new ViewboxPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 21 && columnNumber == 40)
                {
                    isobj3HeightDisabled = true;
                }
                else if (lineNumber == 22 && columnNumber == 21)
                {
                    isobj3WidthDisabled = true;
                }
                else if (lineNumber == 75 && columnNumber == 62)
                {
                    isobj12ValueDisabled = true;
                }
                else if (lineNumber == 76 && columnNumber == 65)
                {
                    isobj13ValueDisabled = true;
                }
                else if (lineNumber == 77 && columnNumber == 74)
                {
                    isobj14ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // ControlPages\ViewboxPage.xaml line 21
                        this.obj3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Viewbox>(target);
                        break;
                    case 12: // ControlPages\ViewboxPage.xaml line 75
                        this.obj12 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                        break;
                    case 13: // ControlPages\ViewboxPage.xaml line 76
                        this.obj13 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                        break;
                    case 14: // ControlPages\ViewboxPage.xaml line 77
                        this.obj14 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
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

            // IViewboxPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.ViewboxPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.ViewboxPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SizeSlider(obj.SizeSlider, phase);
                        this.Update_Control1(obj.Control1, phase);
                    }
                }
            }
            private void Update_SizeSlider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SizeSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SizeSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_SizeSlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ViewboxPage.xaml line 21
                    if (!isobj3HeightDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Height(this.obj3, obj);
                    }
                    // ControlPages\ViewboxPage.xaml line 21
                    if (!isobj3WidthDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Width(this.obj3, obj);
                    }
                    // ControlPages\ViewboxPage.xaml line 75
                    if (!isobj12ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj12, obj, null);
                    }
                }
            }
            private void Update_Control1(global::Microsoft.UI.Xaml.Controls.Viewbox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Control1(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Control1_Stretch(obj.Stretch, phase);
                        this.Update_Control1_StretchDirection(obj.StretchDirection, phase);
                    }
                }
            }
            private void Update_Control1_Stretch(global::Microsoft.UI.Xaml.Media.Stretch obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ViewboxPage.xaml line 76
                    if (!isobj13ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj13, obj, null);
                    }
                }
            }
            private void Update_Control1_StretchDirection(global::Microsoft.UI.Xaml.Controls.StretchDirection obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ViewboxPage.xaml line 77
                    if (!isobj14ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj14, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ViewboxPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ViewboxPage_obj1_Bindings> weakRefToBindingObj; 

                public ViewboxPage_obj1_BindingsTracking(ViewboxPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ViewboxPage_obj1_Bindings>(obj);
                }

                public ViewboxPage_obj1_Bindings TryGetBindingObject()
                {
                    ViewboxPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_SizeSlider(null);
                    UpdateChildListeners_Control1(null);
                }

                public void DependencyPropertyChanged_SizeSlider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ViewboxPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_SizeSlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_SizeSlider = null;
                private long tokenDPC_SizeSlider_Value = 0;
                public void UpdateChildListeners_SizeSlider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_SizeSlider)
                    {
                        if (cache_SizeSlider != null)
                        {
                            cache_SizeSlider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_SizeSlider_Value);
                            cache_SizeSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_SizeSlider = obj;
                            tokenDPC_SizeSlider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_SizeSlider_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_Control1_Stretch(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ViewboxPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Viewbox obj = sender as global::Microsoft.UI.Xaml.Controls.Viewbox;
                        if (obj != null)
                        {
                            bindings.Update_Control1_Stretch(obj.Stretch, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Control1_StretchDirection(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ViewboxPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Viewbox obj = sender as global::Microsoft.UI.Xaml.Controls.Viewbox;
                        if (obj != null)
                        {
                            bindings.Update_Control1_StretchDirection(obj.StretchDirection, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Viewbox cache_Control1 = null;
                private long tokenDPC_Control1_Stretch = 0;
                private long tokenDPC_Control1_StretchDirection = 0;
                public void UpdateChildListeners_Control1(global::Microsoft.UI.Xaml.Controls.Viewbox obj)
                {
                    if (obj != cache_Control1)
                    {
                        if (cache_Control1 != null)
                        {
                            cache_Control1.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Viewbox.StretchProperty, tokenDPC_Control1_Stretch);
                            cache_Control1.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Viewbox.StretchDirectionProperty, tokenDPC_Control1_StretchDirection);
                            cache_Control1 = null;
                        }
                        if (obj != null)
                        {
                            cache_Control1 = obj;
                            tokenDPC_Control1_Stretch = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Viewbox.StretchProperty, DependencyPropertyChanged_Control1_Stretch);
                            tokenDPC_Control1_StretchDirection = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Viewbox.StretchDirectionProperty, DependencyPropertyChanged_Control1_StretchDirection);
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
            case 2: // ControlPages\ViewboxPage.xaml line 20
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\ViewboxPage.xaml line 21
                {
                    this.Control1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Viewbox>(target);
                }
                break;
            case 4: // ControlPages\ViewboxPage.xaml line 39
                {
                    this.SizeSlider = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Slider>(target);
                }
                break;
            case 5: // ControlPages\ViewboxPage.xaml line 49
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element5).Checked += this.StretchDirectionButton_Checked;
                }
                break;
            case 6: // ControlPages\ViewboxPage.xaml line 50
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element6).Checked += this.StretchDirectionButton_Checked;
                }
                break;
            case 7: // ControlPages\ViewboxPage.xaml line 51
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element7).Checked += this.StretchDirectionButton_Checked;
                }
                break;
            case 8: // ControlPages\ViewboxPage.xaml line 42
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element8).Checked += this.StretchButton_Checked;
                }
                break;
            case 9: // ControlPages\ViewboxPage.xaml line 43
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element9).Checked += this.StretchButton_Checked;
                }
                break;
            case 10: // ControlPages\ViewboxPage.xaml line 44
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element10).Checked += this.StretchButton_Checked;
                }
                break;
            case 11: // ControlPages\ViewboxPage.xaml line 45
                {
                    global::Microsoft.UI.Xaml.Controls.RadioButton element11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RadioButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RadioButton)element11).Checked += this.StretchButton_Checked;
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
            case 1: // ControlPages\ViewboxPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ViewboxPage_obj1_Bindings bindings = new ViewboxPage_obj1_Bindings();
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

