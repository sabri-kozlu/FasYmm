﻿#pragma checksum "C:\Users\sabri\Desktop\FasWebAPI\dev2ninovasyon\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\DesignGuidance\IconographyPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87F0069310031436CE8D9FEE31196FDD3FBF6E57C36DEDC612C7630D5FC6E026"
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
    partial class IconographyPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_FrameworkElement_DataContext(global::Microsoft.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.DataContext = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_FontIcon_FontSize(global::Microsoft.UI.Xaml.Controls.FontIcon obj, global::System.Double value)
            {
                obj.FontSize = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class IconographyPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IIconographyPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.IconographyPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.Grid obj5;
            private global::Microsoft.UI.Xaml.Controls.FontIcon obj6;
            private global::Microsoft.UI.Xaml.Controls.ComboBox obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5DataContextDisabled = false;
            private static bool isobj6FontSizeDisabled = false;
            private static bool isobj10ItemsSourceDisabled = false;

            private IconographyPage_obj1_BindingsTracking bindingsTracking;

            public IconographyPage_obj1_Bindings()
            {
                this.bindingsTracking = new IconographyPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 183 && columnNumber == 21)
                {
                    isobj5DataContextDisabled = true;
                }
                else if (lineNumber == 194 && columnNumber == 29)
                {
                    isobj6FontSizeDisabled = true;
                }
                else if (lineNumber == 238 && columnNumber == 37)
                {
                    isobj10ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // ControlPages\DesignGuidance\IconographyPage.xaml line 177
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                        break;
                    case 6: // ControlPages\DesignGuidance\IconographyPage.xaml line 189
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.FontIcon>(target);
                        break;
                    case 10: // ControlPages\DesignGuidance\IconographyPage.xaml line 235
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
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

            // IIconographyPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.IconographyPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.IconographyPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FontsizeComboBox(obj.FontsizeComboBox, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FontSizes(obj.FontSizes, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\DesignGuidance\IconographyPage.xaml line 177
                    if (!isobj5DataContextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_DataContext(this.obj5, obj, null);
                    }
                }
            }
            private void Update_FontsizeComboBox(global::Microsoft.UI.Xaml.Controls.ComboBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_FontsizeComboBox(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FontsizeComboBox_SelectedValue(obj.SelectedValue, phase);
                    }
                }
            }
            private void Update_FontsizeComboBox_SelectedValue(global::System.Object obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FontsizeComboBox_SelectedValue_Cast_SelectedValue_To_Double((global::System.Double)obj, phase);
                    }
                }
            }
            private void Update_FontsizeComboBox_SelectedValue_Cast_SelectedValue_To_Double(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\DesignGuidance\IconographyPage.xaml line 189
                    if (!isobj6FontSizeDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_FontIcon_FontSize(this.obj6, obj);
                    }
                }
            }
            private void Update_FontSizes(global::System.Collections.Generic.List<global::System.Double> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\DesignGuidance\IconographyPage.xaml line 235
                    if (!isobj10ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class IconographyPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<IconographyPage_obj1_Bindings> weakRefToBindingObj; 

                public IconographyPage_obj1_BindingsTracking(IconographyPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<IconographyPage_obj1_Bindings>(obj);
                }

                public IconographyPage_obj1_Bindings TryGetBindingObject()
                {
                    IconographyPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_FontsizeComboBox(null);
                }

                public void DependencyPropertyChanged_FontsizeComboBox_SelectedValue(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    IconographyPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ComboBox obj = sender as global::Microsoft.UI.Xaml.Controls.ComboBox;
                        if (obj != null)
                        {
                            bindings.Update_FontsizeComboBox_SelectedValue(obj.SelectedValue, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ComboBox cache_FontsizeComboBox = null;
                private long tokenDPC_FontsizeComboBox_SelectedValue = 0;
                public void UpdateChildListeners_FontsizeComboBox(global::Microsoft.UI.Xaml.Controls.ComboBox obj)
                {
                    if (obj != cache_FontsizeComboBox)
                    {
                        if (cache_FontsizeComboBox != null)
                        {
                            cache_FontsizeComboBox.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, tokenDPC_FontsizeComboBox_SelectedValue);
                            cache_FontsizeComboBox = null;
                        }
                        if (obj != null)
                        {
                            cache_FontsizeComboBox = obj;
                            tokenDPC_FontsizeComboBox_SelectedValue = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedValueProperty, DependencyPropertyChanged_FontsizeComboBox_SelectedValue);
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
            case 7: // ControlPages\DesignGuidance\IconographyPage.xaml line 206
                {
                    this.XAMLCodePresenter = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.Controls.SampleCodePresenter>(target);
                }
                break;
            case 8: // ControlPages\DesignGuidance\IconographyPage.xaml line 208
                {
                    this.CSharpCodePresenter = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.Controls.SampleCodePresenter>(target);
                }
                break;
            case 9: // ControlPages\DesignGuidance\IconographyPage.xaml line 215
                {
                    this.IconColorPicker = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.DesktopWap.Controls.InlineColorPicker>(target);
                }
                break;
            case 10: // ControlPages\DesignGuidance\IconographyPage.xaml line 235
                {
                    this.FontsizeComboBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                }
                break;
            case 11: // ControlPages\DesignGuidance\IconographyPage.xaml line 163
                {
                    this.IconsItemsView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ItemsView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ItemsView)this.IconsItemsView).SelectionChanged += this.IconsItemsView_SelectionChanged;
                }
                break;
            case 12: // ControlPages\DesignGuidance\IconographyPage.xaml line 138
                {
                    this.IconsAutoSuggestBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AutoSuggestBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AutoSuggestBox)this.IconsAutoSuggestBox).TextChanged += this.SearchTextBox_TextChanged;
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
            case 1: // ControlPages\DesignGuidance\IconographyPage.xaml line 13
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    IconographyPage_obj1_Bindings bindings = new IconographyPage_obj1_Bindings();
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

