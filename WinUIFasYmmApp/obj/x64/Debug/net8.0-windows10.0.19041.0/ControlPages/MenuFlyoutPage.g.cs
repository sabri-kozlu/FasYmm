﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\ControlPages\MenuFlyoutPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8D005C9537B61270C91CBB0DCABD9F061171FC6AEF2BAB3E0687DAEC28F2A16"
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
    partial class MenuFlyoutPage : 
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
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class MenuFlyoutPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMenuFlyoutPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.MenuFlyoutPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj15;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj15ValueDisabled = false;
            private static bool isobj16ValueDisabled = false;

            private MenuFlyoutPage_obj1_BindingsTracking bindingsTracking;

            public MenuFlyoutPage_obj1_Bindings()
            {
                this.bindingsTracking = new MenuFlyoutPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 72 && columnNumber == 70)
                {
                    isobj15ValueDisabled = true;
                }
                else if (lineNumber == 73 && columnNumber == 71)
                {
                    isobj16ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 15: // ControlPages\MenuFlyoutPage.xaml line 72
                        this.obj15 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                        break;
                    case 16: // ControlPages\MenuFlyoutPage.xaml line 73
                        this.obj16 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
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

            // IMenuFlyoutPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.MenuFlyoutPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.MenuFlyoutPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RepeatToggleMenuFlyoutItem(obj.RepeatToggleMenuFlyoutItem, phase);
                        this.Update_ShuffleToggleMenuFlyoutItem(obj.ShuffleToggleMenuFlyoutItem, phase);
                    }
                }
            }
            private void Update_RepeatToggleMenuFlyoutItem(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_RepeatToggleMenuFlyoutItem(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RepeatToggleMenuFlyoutItem_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_RepeatToggleMenuFlyoutItem_IsChecked(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\MenuFlyoutPage.xaml line 72
                    if (!isobj15ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj15, obj, null);
                    }
                }
            }
            private void Update_ShuffleToggleMenuFlyoutItem(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ShuffleToggleMenuFlyoutItem(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ShuffleToggleMenuFlyoutItem_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_ShuffleToggleMenuFlyoutItem_IsChecked(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\MenuFlyoutPage.xaml line 73
                    if (!isobj16ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj16, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MenuFlyoutPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MenuFlyoutPage_obj1_Bindings> weakRefToBindingObj; 

                public MenuFlyoutPage_obj1_BindingsTracking(MenuFlyoutPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MenuFlyoutPage_obj1_Bindings>(obj);
                }

                public MenuFlyoutPage_obj1_Bindings TryGetBindingObject()
                {
                    MenuFlyoutPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_RepeatToggleMenuFlyoutItem(null);
                    UpdateChildListeners_ShuffleToggleMenuFlyoutItem(null);
                }

                public void DependencyPropertyChanged_RepeatToggleMenuFlyoutItem_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    MenuFlyoutPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem obj = sender as global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem;
                        if (obj != null)
                        {
                            bindings.Update_RepeatToggleMenuFlyoutItem_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem cache_RepeatToggleMenuFlyoutItem = null;
                private long tokenDPC_RepeatToggleMenuFlyoutItem_IsChecked = 0;
                public void UpdateChildListeners_RepeatToggleMenuFlyoutItem(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem obj)
                {
                    if (obj != cache_RepeatToggleMenuFlyoutItem)
                    {
                        if (cache_RepeatToggleMenuFlyoutItem != null)
                        {
                            cache_RepeatToggleMenuFlyoutItem.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem.IsCheckedProperty, tokenDPC_RepeatToggleMenuFlyoutItem_IsChecked);
                            cache_RepeatToggleMenuFlyoutItem = null;
                        }
                        if (obj != null)
                        {
                            cache_RepeatToggleMenuFlyoutItem = obj;
                            tokenDPC_RepeatToggleMenuFlyoutItem_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem.IsCheckedProperty, DependencyPropertyChanged_RepeatToggleMenuFlyoutItem_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_ShuffleToggleMenuFlyoutItem_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    MenuFlyoutPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem obj = sender as global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem;
                        if (obj != null)
                        {
                            bindings.Update_ShuffleToggleMenuFlyoutItem_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem cache_ShuffleToggleMenuFlyoutItem = null;
                private long tokenDPC_ShuffleToggleMenuFlyoutItem_IsChecked = 0;
                public void UpdateChildListeners_ShuffleToggleMenuFlyoutItem(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem obj)
                {
                    if (obj != cache_ShuffleToggleMenuFlyoutItem)
                    {
                        if (cache_ShuffleToggleMenuFlyoutItem != null)
                        {
                            cache_ShuffleToggleMenuFlyoutItem.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem.IsCheckedProperty, tokenDPC_ShuffleToggleMenuFlyoutItem_IsChecked);
                            cache_ShuffleToggleMenuFlyoutItem = null;
                        }
                        if (obj != null)
                        {
                            cache_ShuffleToggleMenuFlyoutItem = obj;
                            tokenDPC_ShuffleToggleMenuFlyoutItem_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem.IsCheckedProperty, DependencyPropertyChanged_ShuffleToggleMenuFlyoutItem_IsChecked);
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
            case 2: // ControlPages\MenuFlyoutPage.xaml line 18
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\MenuFlyoutPage.xaml line 45
                {
                    this.Example2 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 4: // ControlPages\MenuFlyoutPage.xaml line 76
                {
                    this.Example3 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 5: // ControlPages\MenuFlyoutPage.xaml line 114
                {
                    this.Example4 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 6: // ControlPages\MenuFlyoutPage.xaml line 153
                {
                    this.Example5 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                    ((global::WinUIFasYmmApp.ControlExample)this.Example5).Loaded += this.Example5_Loaded;
                }
                break;
            case 7: // ControlPages\MenuFlyoutPage.xaml line 215
                {
                    this.Example6 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 8: // ControlPages\MenuFlyoutPage.xaml line 216
                {
                    this.Control6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 9: // ControlPages\MenuFlyoutPage.xaml line 155
                {
                    this.Control5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 10: // ControlPages\MenuFlyoutPage.xaml line 116
                {
                    this.Control4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 11: // ControlPages\MenuFlyoutPage.xaml line 77
                {
                    this.Control3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 12: // ControlPages\MenuFlyoutPage.xaml line 47
                {
                    this.Control2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 13: // ControlPages\MenuFlyoutPage.xaml line 52
                {
                    this.RepeatToggleMenuFlyoutItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem>(target);
                }
                break;
            case 14: // ControlPages\MenuFlyoutPage.xaml line 53
                {
                    this.ShuffleToggleMenuFlyoutItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem>(target);
                }
                break;
            case 17: // ControlPages\MenuFlyoutPage.xaml line 19
                {
                    this.Control1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 18: // ControlPages\MenuFlyoutPage.xaml line 29
                {
                    this.Control1Output = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 19: // ControlPages\MenuFlyoutPage.xaml line 23
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element19 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element19).Click += this.MenuFlyoutItem_Click;
                }
                break;
            case 20: // ControlPages\MenuFlyoutPage.xaml line 24
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element20 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element20).Click += this.MenuFlyoutItem_Click;
                }
                break;
            case 21: // ControlPages\MenuFlyoutPage.xaml line 25
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element21 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element21).Click += this.MenuFlyoutItem_Click;
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
            case 1: // ControlPages\MenuFlyoutPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    MenuFlyoutPage_obj1_Bindings bindings = new MenuFlyoutPage_obj1_Bindings();
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

