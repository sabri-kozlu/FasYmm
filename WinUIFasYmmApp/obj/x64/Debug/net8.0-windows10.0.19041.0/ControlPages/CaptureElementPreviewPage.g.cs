﻿#pragma checksum "C:\Users\sabri\Desktop\FasWebAPI\dev2ninovasyon\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\CaptureElementPreviewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A35E7F5054416F70D906F0537240B204733A4F13D3810797A29E246724FC901C"
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
    partial class CaptureElementPreviewPage : 
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
        private partial class CaptureElementPreviewPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ICaptureElementPreviewPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.CaptureElementPreviewPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinUIFasYmmApp.ControlExampleSubstitution obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10ValueDisabled = false;

            private CaptureElementPreviewPage_obj1_BindingsTracking bindingsTracking;

            public CaptureElementPreviewPage_obj1_Bindings()
            {
                this.bindingsTracking = new CaptureElementPreviewPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 27 && columnNumber == 71)
                {
                    isobj10ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // ControlPages\CaptureElementPreviewPage.xaml line 27
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

            // ICaptureElementPreviewPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.CaptureElementPreviewPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.CaptureElementPreviewPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MirrorTextReplacement(obj.MirrorTextReplacement, phase);
                    }
                }
            }
            private void Update_MirrorTextReplacement(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CaptureElementPreviewPage.xaml line 27
                    if (!isobj10ValueDisabled)
                    {
                        XamlBindingSetters.Set_WinUIFasYmmApp_ControlExampleSubstitution_Value(this.obj10, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CaptureElementPreviewPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<CaptureElementPreviewPage_obj1_Bindings> weakRefToBindingObj; 

                public CaptureElementPreviewPage_obj1_BindingsTracking(CaptureElementPreviewPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CaptureElementPreviewPage_obj1_Bindings>(obj);
                }

                public CaptureElementPreviewPage_obj1_Bindings TryGetBindingObject()
                {
                    CaptureElementPreviewPage_obj1_Bindings bindingObject = null;
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

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CaptureElementPreviewPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::WinUIFasYmmApp.ControlPages.CaptureElementPreviewPage obj = sender as global::WinUIFasYmmApp.ControlPages.CaptureElementPreviewPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_MirrorTextReplacement(obj.MirrorTextReplacement, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "MirrorTextReplacement":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MirrorTextReplacement(obj.MirrorTextReplacement, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::WinUIFasYmmApp.ControlPages.CaptureElementPreviewPage obj)
                {
                    CaptureElementPreviewPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
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
            case 2: // ControlPages\CaptureElementPreviewPage.xaml line 7
                {
                    this.Example1 = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlExample>(target);
                }
                break;
            case 3: // ControlPages\CaptureElementPreviewPage.xaml line 10
                {
                    this.frameSourceName = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 4: // ControlPages\CaptureElementPreviewPage.xaml line 11
                {
                    this.captureElement = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MediaPlayerElement>(target);
                }
                break;
            case 5: // ControlPages\CaptureElementPreviewPage.xaml line 12
                {
                    this.capturedText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 6: // ControlPages\CaptureElementPreviewPage.xaml line 13
                {
                    this.captureContainer = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 7: // ControlPages\CaptureElementPreviewPage.xaml line 15
                {
                    this.snapshots = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 8: // ControlPages\CaptureElementPreviewPage.xaml line 22
                {
                    this.mirrorSwitch = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ToggleSwitch>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ToggleSwitch)this.mirrorSwitch).Toggled += this.MirrorToggleSwitch_Toggled;
                }
                break;
            case 9: // ControlPages\CaptureElementPreviewPage.xaml line 23
                {
                    this.captureButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.captureButton).Click += this.CapturePhoto_Click;
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
            case 1: // ControlPages\CaptureElementPreviewPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    CaptureElementPreviewPage_obj1_Bindings bindings = new CaptureElementPreviewPage_obj1_Bindings();
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

