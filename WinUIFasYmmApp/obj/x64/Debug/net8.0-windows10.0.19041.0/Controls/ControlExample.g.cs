﻿#pragma checksum "C:\Users\2NSenior\source\repos\WinUIFasYmmApp\WinUIFasYmmApp\Controls\ControlExample.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F74D91243A092C9A6836E4AD56F0D9738C0C3D016D9A0ED19666BA66A092F3DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUIFasYmmApp
{
    partial class ControlExample : 
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
            public static void Set_WinUIFasYmmApp_Controls_SampleCodePresenter_Code(global::WinUIFasYmmApp.Controls.SampleCodePresenter obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Code = value ?? global::System.String.Empty;
            }
            public static void Set_WinUIFasYmmApp_Controls_SampleCodePresenter_CodeSourceFile(global::WinUIFasYmmApp.Controls.SampleCodePresenter obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.CodeSourceFile = value ?? global::System.String.Empty;
            }
            public static void Set_WinUIFasYmmApp_Controls_SampleCodePresenter_Substitutions(global::WinUIFasYmmApp.Controls.SampleCodePresenter obj, global::System.Collections.Generic.IList<global::WinUIFasYmmApp.ControlExampleSubstitution> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.IList<global::WinUIFasYmmApp.ControlExampleSubstitution>) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.IList<global::WinUIFasYmmApp.ControlExampleSubstitution>), targetNullValue);
                }
                obj.Substitutions = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ContentPresenter_HorizontalContentAlignment(global::Microsoft.UI.Xaml.Controls.ContentPresenter obj, global::Microsoft.UI.Xaml.HorizontalAlignment value)
            {
                obj.HorizontalContentAlignment = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(global::Microsoft.UI.Xaml.Controls.ContentPresenter obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class ControlExample_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IControlExample_Bindings
        {
            private global::WinUIFasYmmApp.ControlExample dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Microsoft.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Microsoft.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj5;
            private global::WinUIFasYmmApp.Controls.SampleCodePresenter obj8;
            private global::WinUIFasYmmApp.Controls.SampleCodePresenter obj9;
            private global::Microsoft.UI.Xaml.Controls.ContentPresenter obj13;
            private global::Microsoft.UI.Xaml.Controls.StackPanel obj14;
            private global::Microsoft.UI.Xaml.Controls.ContentPresenter obj15;
            private global::Microsoft.UI.Xaml.Controls.ContentPresenter obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5TextDisabled = false;
            private static bool isobj8CodeDisabled = false;
            private static bool isobj8CodeSourceFileDisabled = false;
            private static bool isobj8SubstitutionsDisabled = false;
            private static bool isobj9CodeDisabled = false;
            private static bool isobj9CodeSourceFileDisabled = false;
            private static bool isobj9SubstitutionsDisabled = false;
            private static bool isobj13HorizontalContentAlignmentDisabled = false;
            private static bool isobj13ContentDisabled = false;
            private static bool isobj14VisibilityDisabled = false;
            private static bool isobj15ContentDisabled = false;
            private static bool isobj15VisibilityDisabled = false;
            private static bool isobj16ContentDisabled = false;

            private ControlExample_obj1_BindingsTracking bindingsTracking;

            public ControlExample_obj1_Bindings()
            {
                this.bindingsTracking = new ControlExample_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 72 && columnNumber == 13)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 178 && columnNumber == 29)
                {
                    isobj8CodeDisabled = true;
                }
                else if (lineNumber == 180 && columnNumber == 29)
                {
                    isobj8CodeSourceFileDisabled = true;
                }
                else if (lineNumber == 181 && columnNumber == 29)
                {
                    isobj8SubstitutionsDisabled = true;
                }
                else if (lineNumber == 187 && columnNumber == 29)
                {
                    isobj9CodeDisabled = true;
                }
                else if (lineNumber == 189 && columnNumber == 29)
                {
                    isobj9CodeSourceFileDisabled = true;
                }
                else if (lineNumber == 190 && columnNumber == 29)
                {
                    isobj9SubstitutionsDisabled = true;
                }
                else if (lineNumber == 115 && columnNumber == 25)
                {
                    isobj13HorizontalContentAlignmentDisabled = true;
                }
                else if (lineNumber == 119 && columnNumber == 25)
                {
                    isobj13ContentDisabled = true;
                }
                else if (lineNumber == 132 && columnNumber == 25)
                {
                    isobj14VisibilityDisabled = true;
                }
                else if (lineNumber == 147 && columnNumber == 25)
                {
                    isobj15ContentDisabled = true;
                }
                else if (lineNumber == 148 && columnNumber == 25)
                {
                    isobj15VisibilityDisabled = true;
                }
                else if (lineNumber == 134 && columnNumber == 68)
                {
                    isobj16ContentDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Controls\ControlExample.xaml line 67
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 8: // Controls\ControlExample.xaml line 175
                        this.obj8 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.Controls.SampleCodePresenter>(target);
                        break;
                    case 9: // Controls\ControlExample.xaml line 184
                        this.obj9 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.Controls.SampleCodePresenter>(target);
                        break;
                    case 13: // Controls\ControlExample.xaml line 110
                        this.obj13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                        break;
                    case 14: // Controls\ControlExample.xaml line 123
                        this.obj14 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                        break;
                    case 15: // Controls\ControlExample.xaml line 138
                        this.obj15 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                        break;
                    case 16: // Controls\ControlExample.xaml line 134
                        this.obj16 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
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

            // IControlExample_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(newDataRoot);
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
            public void SetConverterLookupRoot(global::Microsoft.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Microsoft.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Microsoft.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Microsoft.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Microsoft.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Microsoft.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WinUIFasYmmApp.ControlExample obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_HeaderText(obj.HeaderText, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Xaml(obj.Xaml, phase);
                        this.Update_XamlSource(obj.XamlSource, phase);
                        this.Update_Substitutions(obj.Substitutions, phase);
                        this.Update_CSharp(obj.CSharp, phase);
                        this.Update_CSharpSource(obj.CSharpSource, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_HorizontalContentAlignment(obj.HorizontalContentAlignment, phase);
                        this.Update_Example(obj.Example, phase);
                        this.Update_Output(obj.Output, phase);
                        this.Update_Options(obj.Options, phase);
                    }
                }
            }
            private void Update_HeaderText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 67
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_Xaml(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 175
                    if (!isobj8CodeDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_Controls_SampleCodePresenter_Code(this.obj8, obj, null);
                    }
                }
            }
            private void Update_XamlSource(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 175
                    if (!isobj8CodeSourceFileDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_Controls_SampleCodePresenter_CodeSourceFile(this.obj8, obj, null);
                    }
                }
            }
            private void Update_Substitutions(global::System.Collections.Generic.IList<global::WinUIFasYmmApp.ControlExampleSubstitution> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 175
                    if (!isobj8SubstitutionsDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_Controls_SampleCodePresenter_Substitutions(this.obj8, obj, null);
                    }
                    // Controls\ControlExample.xaml line 184
                    if (!isobj9SubstitutionsDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_Controls_SampleCodePresenter_Substitutions(this.obj9, obj, null);
                    }
                }
            }
            private void Update_CSharp(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 184
                    if (!isobj9CodeDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_Controls_SampleCodePresenter_Code(this.obj9, obj, null);
                    }
                }
            }
            private void Update_CSharpSource(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ControlExample.xaml line 184
                    if (!isobj9CodeSourceFileDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_Controls_SampleCodePresenter_CodeSourceFile(this.obj9, obj, null);
                    }
                }
            }
            private void Update_HorizontalContentAlignment(global::Microsoft.UI.Xaml.HorizontalAlignment obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 110
                    if (!isobj13HorizontalContentAlignmentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_HorizontalContentAlignment(this.obj13, obj);
                    }
                }
            }
            private void Update_Example(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 110
                    if (!isobj13ContentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(this.obj13, obj, null);
                    }
                }
            }
            private void Update_Output(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 123
                    if (!isobj14VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj14, (global::Microsoft.UI.Xaml.Visibility)this.LookupConverter("nullToVisibilityConverter").Convert(obj, typeof(global::Microsoft.UI.Xaml.Visibility), null, null));
                    }
                    // Controls\ControlExample.xaml line 134
                    if (!isobj16ContentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(this.obj16, obj, null);
                    }
                }
            }
            private void Update_Options(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ControlExample.xaml line 138
                    if (!isobj15ContentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(this.obj15, obj, null);
                    }
                    // Controls\ControlExample.xaml line 138
                    if (!isobj15VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj15, (global::Microsoft.UI.Xaml.Visibility)this.LookupConverter("nullToVisibilityConverter").Convert(obj, typeof(global::Microsoft.UI.Xaml.Visibility), null, null));
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ControlExample_obj1_BindingsTracking
            {
                private global::System.WeakReference<ControlExample_obj1_Bindings> weakRefToBindingObj; 

                public ControlExample_obj1_BindingsTracking(ControlExample_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ControlExample_obj1_Bindings>(obj);
                }

                public ControlExample_obj1_Bindings TryGetBindingObject()
                {
                    ControlExample_obj1_Bindings bindingObject = null;
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

                public void DependencyPropertyChanged_Xaml(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.ControlExample obj = sender as global::WinUIFasYmmApp.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_Xaml(obj.Xaml, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_XamlSource(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.ControlExample obj = sender as global::WinUIFasYmmApp.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_XamlSource(obj.XamlSource, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Substitutions(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.ControlExample obj = sender as global::WinUIFasYmmApp.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_Substitutions(obj.Substitutions, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_CSharp(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.ControlExample obj = sender as global::WinUIFasYmmApp.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_CSharp(obj.CSharp, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_CSharpSource(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::WinUIFasYmmApp.ControlExample obj = sender as global::WinUIFasYmmApp.ControlExample;
                        if (obj != null)
                        {
                            bindings.Update_CSharpSource(obj.CSharpSource, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Xaml = 0;
                private long tokenDPC_XamlSource = 0;
                private long tokenDPC_Substitutions = 0;
                private long tokenDPC_CSharp = 0;
                private long tokenDPC_CSharpSource = 0;
                public void UpdateChildListeners_(global::WinUIFasYmmApp.ControlExample obj)
                {
                    ControlExample_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.XamlProperty, tokenDPC_Xaml);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.XamlSourceProperty, tokenDPC_XamlSource);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.SubstitutionsProperty, tokenDPC_Substitutions);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.CSharpProperty, tokenDPC_CSharp);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.CSharpSourceProperty, tokenDPC_CSharpSource);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Xaml = obj.RegisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.XamlProperty, DependencyPropertyChanged_Xaml);
                            tokenDPC_XamlSource = obj.RegisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.XamlSourceProperty, DependencyPropertyChanged_XamlSource);
                            tokenDPC_Substitutions = obj.RegisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.SubstitutionsProperty, DependencyPropertyChanged_Substitutions);
                            tokenDPC_CSharp = obj.RegisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.CSharpProperty, DependencyPropertyChanged_CSharp);
                            tokenDPC_CSharpSource = obj.RegisterPropertyChangedCallback(global::WinUIFasYmmApp.ControlExample.CSharpSourceProperty, DependencyPropertyChanged_CSharpSource);
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
            case 1: // Controls\ControlExample.xaml line 1
                {
                    this.RootPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.UserControl>(target);
                }
                break;
            case 2: // Controls\ControlExample.xaml line 18
                {
                    this.ShowTransitions = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.Animations.ImplicitAnimationSet>(target);
                }
                break;
            case 3: // Controls\ControlExample.xaml line 28
                {
                    this.HideTransitions = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.Animations.ImplicitAnimationSet>(target);
                }
                break;
            case 4: // Controls\ControlExample.xaml line 39
                {
                    this.rootGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 5: // Controls\ControlExample.xaml line 67
                {
                    this.HeaderTextPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 6: // Controls\ControlExample.xaml line 74
                {
                    this.ErrorTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RichTextBlock>(target);
                }
                break;
            case 7: // Controls\ControlExample.xaml line 168
                {
                    this.SelectorBarControl = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBar>(target);
                    ((global::Microsoft.UI.Xaml.Controls.SelectorBar)this.SelectorBarControl).SelectionChanged += this.SelectorBarControl_SelectionChanged;
                }
                break;
            case 8: // Controls\ControlExample.xaml line 175
                {
                    this.XamlPresenter = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.Controls.SampleCodePresenter>(target);
                }
                break;
            case 9: // Controls\ControlExample.xaml line 184
                {
                    this.CSharpPresenter = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.Controls.SampleCodePresenter>(target);
                }
                break;
            case 10: // Controls\ControlExample.xaml line 169
                {
                    this.SelectorBarXamlItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.SelectorBarItem)this.SelectorBarXamlItem).Loaded += this.SelectorBarItem_Loaded;
                }
                break;
            case 11: // Controls\ControlExample.xaml line 170
                {
                    this.SelectorBarCSharpItem = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.SelectorBarItem)this.SelectorBarCSharpItem).Loaded += this.SelectorBarItem_Loaded;
                }
                break;
            case 12: // Controls\ControlExample.xaml line 94
                {
                    this.ExampleContainer = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 13: // Controls\ControlExample.xaml line 110
                {
                    this.ControlPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                }
                break;
            case 15: // Controls\ControlExample.xaml line 138
                {
                    this.OptionsPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                }
                break;
            case 16: // Controls\ControlExample.xaml line 134
                {
                    this.OutputPresenter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ContentPresenter>(target);
                }
                break;
            case 17: // Controls\ControlExample.xaml line 199
                {
                    this.IntermediateLayout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 18: // Controls\ControlExample.xaml line 204
                {
                    this.PhoneLayout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
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
            case 1: // Controls\ControlExample.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    ControlExample_obj1_Bindings bindings = new ControlExample_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
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
