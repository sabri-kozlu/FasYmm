﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\ControlPages\ProgressRingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9BF5A5579668BF0B994BB4AF45F91493D34289375A9188812F8565F124919AF5"
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
    partial class ProgressRingPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(global::WinUIFasYmmApp.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ProgressRing_IsActive(global::Microsoft.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class ProgressRingPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IProgressRingPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.ProgressRingPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj6;
            private global::Microsoft.UI.Xaml.Controls.ProgressRing obj8;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6ValueDisabled = false;
            private static bool isobj8IsActiveDisabled = false;
            private static bool isobj11ValueDisabled = false;

            private ProgressRingPage_obj1_BindingsTracking bindingsTracking;

            public ProgressRingPage_obj1_Bindings()
            {
                this.bindingsTracking = new ProgressRingPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 74 && columnNumber == 82)
                {
                    isobj6ValueDisabled = true;
                }
                else if (lineNumber == 24 && columnNumber == 50)
                {
                    isobj8IsActiveDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 66)
                {
                    isobj11ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // ControlPages\ProgressRingPage.xaml line 74
                        this.obj6 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                        break;
                    case 8: // ControlPages\ProgressRingPage.xaml line 24
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ProgressRing>(target);
                        break;
                    case 11: // ControlPages\ProgressRingPage.xaml line 40
                        this.obj11 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
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

            // IProgressRingPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.ProgressRingPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.ProgressRingPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProgressRing2(obj.ProgressRing2, phase);
                        this.Update_ProgressToggle(obj.ProgressToggle, phase);
                    }
                }
            }
            private void Update_ProgressRing2(global::Microsoft.UI.Xaml.Controls.ProgressRing obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ProgressRing2(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProgressRing2_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_ProgressRing2_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ProgressRingPage.xaml line 74
                    if (!isobj6ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ProgressToggle(global::Microsoft.UI.Xaml.Controls.ToggleSwitch obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ProgressToggle(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProgressToggle_IsOn(obj.IsOn, phase);
                    }
                }
            }
            private void Update_ProgressToggle_IsOn(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ProgressRingPage.xaml line 24
                    if (!isobj8IsActiveDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ProgressRing_IsActive(this.obj8, obj);
                    }
                    // ControlPages\ProgressRingPage.xaml line 40
                    if (!isobj11ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj11, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ProgressRingPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ProgressRingPage_obj1_Bindings> weakRefToBindingObj; 

                public ProgressRingPage_obj1_BindingsTracking(ProgressRingPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ProgressRingPage_obj1_Bindings>(obj);
                }

                public ProgressRingPage_obj1_Bindings TryGetBindingObject()
                {
                    ProgressRingPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ProgressRing2(null);
                    UpdateChildListeners_ProgressToggle(null);
                }

                public void DependencyPropertyChanged_ProgressRing2_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ProgressRingPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ProgressRing obj = sender as global::Microsoft.UI.Xaml.Controls.ProgressRing;
                        if (obj != null)
                        {
                            bindings.Update_ProgressRing2_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ProgressRing cache_ProgressRing2 = null;
                private long tokenDPC_ProgressRing2_Value = 0;
                public void UpdateChildListeners_ProgressRing2(global::Microsoft.UI.Xaml.Controls.ProgressRing obj)
                {
                    if (obj != cache_ProgressRing2)
                    {
                        if (cache_ProgressRing2 != null)
                        {
                            cache_ProgressRing2.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ProgressRing.ValueProperty, tokenDPC_ProgressRing2_Value);
                            cache_ProgressRing2 = null;
                        }
                        if (obj != null)
                        {
                            cache_ProgressRing2 = obj;
                            tokenDPC_ProgressRing2_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ProgressRing.ValueProperty, DependencyPropertyChanged_ProgressRing2_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_ProgressToggle_IsOn(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ProgressRingPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ToggleSwitch obj = sender as global::Microsoft.UI.Xaml.Controls.ToggleSwitch;
                        if (obj != null)
                        {
                            bindings.Update_ProgressToggle_IsOn(obj.IsOn, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ToggleSwitch cache_ProgressToggle = null;
                private long tokenDPC_ProgressToggle_IsOn = 0;
                public void UpdateChildListeners_ProgressToggle(global::Microsoft.UI.Xaml.Controls.ToggleSwitch obj)
                {
                    if (obj != cache_ProgressToggle)
                    {
                        if (cache_ProgressToggle != null)
                        {
                            cache_ProgressToggle.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ToggleSwitch.IsOnProperty, tokenDPC_ProgressToggle_IsOn);
                            cache_ProgressToggle = null;
                        }
                        if (obj != null)
                        {
                            cache_ProgressToggle = obj;
                            tokenDPC_ProgressToggle_IsOn = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ToggleSwitch.IsOnProperty, DependencyPropertyChanged_ProgressToggle_IsOn);
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
            case 2: // ControlPages\ProgressRingPage.xaml line 47
                {
                    this.Control2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 3: // ControlPages\ProgressRingPage.xaml line 48
                {
                    this.ProgressRing2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ProgressRing>(target);
                }
                break;
            case 4: // ControlPages\ProgressRingPage.xaml line 49
                {
                    this.ProgressValue = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NumberBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NumberBox)this.ProgressValue).ValueChanged += this.ProgressValue_ValueChanged;
                }
                break;
            case 5: // ControlPages\ProgressRingPage.xaml line 60
                {
                    this.BackgroundComboBox2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.BackgroundComboBox2).SelectionChanged += this.Background_SelectionChanged;
                }
                break;
            case 7: // ControlPages\ProgressRingPage.xaml line 75
                {
                    this.RevealBackgroundProperty2 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                }
                break;
            case 8: // ControlPages\ProgressRingPage.xaml line 24
                {
                    this.ProgressRing1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ProgressRing>(target);
                }
                break;
            case 9: // ControlPages\ProgressRingPage.xaml line 27
                {
                    this.ProgressToggle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ToggleSwitch>(target);
                }
                break;
            case 10: // ControlPages\ProgressRingPage.xaml line 28
                {
                    this.BackgroundComboBox1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.BackgroundComboBox1).SelectionChanged += this.Background_SelectionChanged;
                }
                break;
            case 12: // ControlPages\ProgressRingPage.xaml line 41
                {
                    this.RevealBackgroundProperty1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
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
            case 1: // ControlPages\ProgressRingPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ProgressRingPage_obj1_Bindings bindings = new ProgressRingPage_obj1_Bindings();
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

