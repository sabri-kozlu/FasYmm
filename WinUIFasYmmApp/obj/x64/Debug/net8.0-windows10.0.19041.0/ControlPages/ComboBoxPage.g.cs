﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\ControlPages\ComboBoxPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59E4278CE7D5750FE1DCE00927CBF7855A108593BCAE1A455EBDFF79F20B5F94"
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
    partial class ComboBoxPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_FontSize(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.Double value)
            {
                obj.FontSize = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_FontFamily(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::Microsoft.UI.Xaml.Media.FontFamily value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.FontFamily) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.FontFamily), targetNullValue);
                }
                obj.FontFamily = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class ComboBoxPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IComboBoxPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.ComboBoxPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ComboBox obj2;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj3;
            private global::Microsoft.UI.Xaml.Controls.ComboBox obj4;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj3FontSizeDisabled = false;
            private static bool isobj4ItemsSourceDisabled = false;
            private static bool isobj5FontFamilyDisabled = false;

            private ComboBoxPage_obj1_BindingsTracking bindingsTracking;

            public ComboBoxPage_obj1_Bindings()
            {
                this.bindingsTracking = new ComboBoxPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 64 && columnNumber == 82)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 32)
                {
                    isobj3FontSizeDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 47)
                {
                    isobj4ItemsSourceDisabled = true;
                }
                else if (lineNumber == 49 && columnNumber == 29)
                {
                    isobj5FontFamilyDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // ControlPages\ComboBoxPage.xaml line 64
                        this.obj2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                        break;
                    case 3: // ControlPages\ComboBoxPage.xaml line 65
                        this.obj3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 4: // ControlPages\ComboBoxPage.xaml line 46
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                        break;
                    case 5: // ControlPages\ComboBoxPage.xaml line 48
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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

            // IComboBoxPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.ComboBoxPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.ComboBoxPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FontSizes(obj.FontSizes, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Combo3(obj.Combo3, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Fonts(obj.Fonts, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Combo2(obj.Combo2, phase);
                    }
                }
            }
            private void Update_FontSizes(global::System.Collections.Generic.List<global::System.Double> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\ComboBoxPage.xaml line 64
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_Combo3(global::Microsoft.UI.Xaml.Controls.ComboBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Combo3(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Combo3_SelectedValue(obj.SelectedValue, phase);
                    }
                }
            }
            private void Update_Combo3_SelectedValue(global::System.Object obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Combo3_SelectedValue_Cast_SelectedValue_To_Double((global::System.Double)obj, phase);
                    }
                }
            }
            private void Update_Combo3_SelectedValue_Cast_SelectedValue_To_Double(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ComboBoxPage.xaml line 65
                    if (!isobj3FontSizeDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_FontSize(this.obj3, obj);
                    }
                }
            }
            private void Update_Fonts(global::System.Collections.Generic.List<global::System.Tuple<global::System.String, global::Microsoft.UI.Xaml.Media.FontFamily>> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\ComboBoxPage.xaml line 46
                    if (!isobj4ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                    }
                }
            }
            private void Update_Combo2(global::Microsoft.UI.Xaml.Controls.ComboBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Combo2(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Combo2_SelectedValue(obj.SelectedValue, phase);
                    }
                }
            }
            private void Update_Combo2_SelectedValue(global::System.Object obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Combo2_SelectedValue_Cast_SelectedValue_To_FontFamily((global::Microsoft.UI.Xaml.Media.FontFamily)obj, phase);
                    }
                }
            }
            private void Update_Combo2_SelectedValue_Cast_SelectedValue_To_FontFamily(global::Microsoft.UI.Xaml.Media.FontFamily obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ComboBoxPage.xaml line 48
                    if (!isobj5FontFamilyDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_FontFamily(this.obj5, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ComboBoxPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ComboBoxPage_obj1_Bindings> weakRefToBindingObj; 

                public ComboBoxPage_obj1_BindingsTracking(ComboBoxPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ComboBoxPage_obj1_Bindings>(obj);
                }

                public ComboBoxPage_obj1_Bindings TryGetBindingObject()
                {
                    ComboBoxPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_Combo3(null);
                    UpdateChildListeners_Combo2(null);
                }

                public void DependencyPropertyChanged_Combo3_SelectedValue(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ComboBoxPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ComboBox obj = sender as global::Microsoft.UI.Xaml.Controls.ComboBox;
                        if (obj != null)
                        {
                            bindings.Update_Combo3_SelectedValue(obj.SelectedValue, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ComboBox cache_Combo3 = null;
                private long tokenDPC_Combo3_SelectedValue = 0;
                public void UpdateChildListeners_Combo3(global::Microsoft.UI.Xaml.Controls.ComboBox obj)
                {
                    if (obj != cache_Combo3)
                    {
                        if (cache_Combo3 != null)
                        {
                            cache_Combo3.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, tokenDPC_Combo3_SelectedValue);
                            cache_Combo3 = null;
                        }
                        if (obj != null)
                        {
                            cache_Combo3 = obj;
                            tokenDPC_Combo3_SelectedValue = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, DependencyPropertyChanged_Combo3_SelectedValue);
                        }
                    }
                }
                public void DependencyPropertyChanged_Combo2_SelectedValue(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ComboBoxPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ComboBox obj = sender as global::Microsoft.UI.Xaml.Controls.ComboBox;
                        if (obj != null)
                        {
                            bindings.Update_Combo2_SelectedValue(obj.SelectedValue, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ComboBox cache_Combo2 = null;
                private long tokenDPC_Combo2_SelectedValue = 0;
                public void UpdateChildListeners_Combo2(global::Microsoft.UI.Xaml.Controls.ComboBox obj)
                {
                    if (obj != cache_Combo2)
                    {
                        if (cache_Combo2 != null)
                        {
                            cache_Combo2.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, tokenDPC_Combo2_SelectedValue);
                            cache_Combo2 = null;
                        }
                        if (obj != null)
                        {
                            cache_Combo2 = obj;
                            tokenDPC_Combo2_SelectedValue = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, DependencyPropertyChanged_Combo2_SelectedValue);
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
            case 2: // ControlPages\ComboBoxPage.xaml line 64
                {
                    this.Combo3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.Combo3).Loaded += this.Combo3_Loaded;
                }
                break;
            case 3: // ControlPages\ComboBoxPage.xaml line 65
                {
                    this.Control3Output = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 4: // ControlPages\ComboBoxPage.xaml line 46
                {
                    this.Combo2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.Combo2).Loaded += this.Combo2_Loaded;
                }
                break;
            case 5: // ControlPages\ComboBoxPage.xaml line 48
                {
                    this.Control2Output = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 6: // ControlPages\ComboBoxPage.xaml line 21
                {
                    this.Combo1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.Combo1).SelectionChanged += this.ColorComboBox_SelectionChanged;
                }
                break;
            case 7: // ControlPages\ComboBoxPage.xaml line 28
                {
                    this.Control1Output = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
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
            case 1: // ControlPages\ComboBoxPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ComboBoxPage_obj1_Bindings bindings = new ComboBoxPage_obj1_Bindings();
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
