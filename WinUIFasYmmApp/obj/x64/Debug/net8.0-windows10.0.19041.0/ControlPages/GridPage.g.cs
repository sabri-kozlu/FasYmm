﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\GridPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42B9B3BF49E9D504472B99751E04C574C1AF54AB65B97C63419FF6F8CFD0A690"
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
    partial class GridPage : 
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
            public static void Set_Microsoft_UI_Xaml_Controls_Grid_Column(global::Microsoft.UI.Xaml.FrameworkElement obj, global::System.Int32 value)
            {
                global::Microsoft.UI.Xaml.Controls.Grid.SetColumn(obj, value);
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Grid_Row(global::Microsoft.UI.Xaml.FrameworkElement obj, global::System.Int32 value)
            {
                global::Microsoft.UI.Xaml.Controls.Grid.SetRow(obj, value);
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class GridPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IGridPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.GridPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Shapes.Rectangle obj4;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj7;
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4ColumnDisabled = false;
            private static bool isobj4RowDisabled = false;
            private static bool isobj7ValueDisabled = false;
            private static bool isobj8ValueDisabled = false;

            private GridPage_obj1_BindingsTracking bindingsTracking;

            public GridPage_obj1_Bindings()
            {
                this.bindingsTracking = new GridPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 26 && columnNumber == 25)
                {
                    isobj4ColumnDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 25)
                {
                    isobj4RowDisabled = true;
                }
                else if (lineNumber == 58 && columnNumber == 64)
                {
                    isobj7ValueDisabled = true;
                }
                else if (lineNumber == 59 && columnNumber == 61)
                {
                    isobj8ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // ControlPages\GridPage.xaml line 25
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                        break;
                    case 7: // ControlPages\GridPage.xaml line 58
                        this.obj7 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
                        break;
                    case 8: // ControlPages\GridPage.xaml line 59
                        this.obj8 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExampleSubstitution>(target);
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

            // IGridPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.GridPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.GridPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ColumnSlider(obj.ColumnSlider, phase);
                        this.Update_RowSlider(obj.RowSlider, phase);
                    }
                }
            }
            private void Update_ColumnSlider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ColumnSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ColumnSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_ColumnSlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_ColumnSlider_Value_Cast_Value_To_Int32((global::System.Int32)obj, phase);
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\GridPage.xaml line 58
                    if (!isobj7ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ColumnSlider_Value_Cast_Value_To_Int32(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\GridPage.xaml line 25
                    if (!isobj4ColumnDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Grid_Column(this.obj4, obj);
                    }
                }
            }
            private void Update_RowSlider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_RowSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RowSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_RowSlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_RowSlider_Value_Cast_Value_To_Int32((global::System.Int32)obj, phase);
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\GridPage.xaml line 59
                    if (!isobj8ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj8, obj, null);
                    }
                }
            }
            private void Update_RowSlider_Value_Cast_Value_To_Int32(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\GridPage.xaml line 25
                    if (!isobj4RowDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Grid_Row(this.obj4, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class GridPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<GridPage_obj1_Bindings> weakRefToBindingObj; 

                public GridPage_obj1_BindingsTracking(GridPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<GridPage_obj1_Bindings>(obj);
                }

                public GridPage_obj1_Bindings TryGetBindingObject()
                {
                    GridPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ColumnSlider(null);
                    UpdateChildListeners_RowSlider(null);
                }

                public void DependencyPropertyChanged_ColumnSlider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    GridPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_ColumnSlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_ColumnSlider = null;
                private long tokenDPC_ColumnSlider_Value = 0;
                public void UpdateChildListeners_ColumnSlider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_ColumnSlider)
                    {
                        if (cache_ColumnSlider != null)
                        {
                            cache_ColumnSlider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_ColumnSlider_Value);
                            cache_ColumnSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_ColumnSlider = obj;
                            tokenDPC_ColumnSlider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_ColumnSlider_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_RowSlider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    GridPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_RowSlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_RowSlider = null;
                private long tokenDPC_RowSlider_Value = 0;
                public void UpdateChildListeners_RowSlider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_RowSlider)
                    {
                        if (cache_RowSlider != null)
                        {
                            cache_RowSlider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_RowSlider_Value);
                            cache_RowSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_RowSlider = obj;
                            tokenDPC_RowSlider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_RowSlider_Value);
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
            case 2: // ControlPages\GridPage.xaml line 17
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\GridPage.xaml line 18
                {
                    this.Control1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 4: // ControlPages\GridPage.xaml line 25
                {
                    this.Rectangle1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 5: // ControlPages\GridPage.xaml line 36
                {
                    this.RowSlider = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Slider>(target);
                }
                break;
            case 6: // ControlPages\GridPage.xaml line 42
                {
                    this.ColumnSlider = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Slider>(target);
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
            case 1: // ControlPages\GridPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    GridPage_obj1_Bindings bindings = new GridPage_obj1_Bindings();
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

