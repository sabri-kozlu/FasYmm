﻿#pragma checksum "C:\Users\Sa\Desktop\WinUIFasYmmAppV1\WinUIFasYmmApp\ControlPages\RichEditBoxPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE5A1B1BBF9B895DF628FE29555EDBCBBB3C3FD10FAFAAD7E48C5479148C2EC3"
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
    partial class RichEditBoxPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class RichEditBoxPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IRichEditBoxPage_Bindings
        {
            private global::WinUIFasYmmApp.ControlPages.RichEditBoxPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBox obj9;

            // Fields for each event bindings event handler.
            private global::Microsoft.UI.Xaml.Controls.TextChangedEventHandler obj9TextChanged;
            private global::Microsoft.UI.Xaml.RoutedEventHandler obj9GotFocus;
            private global::Microsoft.UI.Xaml.RoutedEventHandler obj9LostFocus;

            // Static fields for each binding's enabled/disabled state

            public RichEditBoxPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 167 && columnNumber == 29)
                {
                    this.obj9.TextChanged -= obj9TextChanged;
                }
                else if (lineNumber == 168 && columnNumber == 29)
                {
                    this.obj9.GotFocus -= obj9GotFocus;
                }
                else if (lineNumber == 169 && columnNumber == 29)
                {
                    this.obj9.LostFocus -= obj9LostFocus;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9: // ControlPages\RichEditBoxPage.xaml line 166
                        this.obj9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                        this.obj9TextChanged = (global::System.Object p0, global::Microsoft.UI.Xaml.Controls.TextChangedEventArgs p1) =>
                        {
                            if (this.dataRoot != null)
                            {
                                this.dataRoot.FindBoxHighlightMatches();
                            }
                        };
                        (global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target)).TextChanged += obj9TextChanged;
                        this.obj9GotFocus = (global::System.Object p0, global::Microsoft.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            if (this.dataRoot != null)
                            {
                                this.dataRoot.FindBoxHighlightMatches();
                            }
                        };
                        (global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target)).GotFocus += obj9GotFocus;
                        this.obj9LostFocus = (global::System.Object p0, global::Microsoft.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            if (this.dataRoot != null)
                            {
                                this.dataRoot.FindBoxRemoveHighlights();
                            }
                        };
                        (global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target)).LostFocus += obj9LostFocus;
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

            // IRichEditBoxPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.ControlPages.RichEditBoxPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.ControlPages.RichEditBoxPage obj, int phase)
            {
                if (obj != null)
                {
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
            case 2: // ControlPages\RichEditBoxPage.xaml line 64
                {
                    this.openFileButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.openFileButton).Click += this.OpenButton_Click;
                }
                break;
            case 3: // ControlPages\RichEditBoxPage.xaml line 69
                {
                    global::Microsoft.UI.Xaml.Controls.Button element3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element3).Click += this.SaveButton_Click;
                }
                break;
            case 4: // ControlPages\RichEditBoxPage.xaml line 75
                {
                    global::Microsoft.UI.Xaml.Controls.Button element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element4).Click += this.BoldButton_Click;
                }
                break;
            case 5: // ControlPages\RichEditBoxPage.xaml line 81
                {
                    this.italicButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.italicButton).Click += this.ItalicButton_Click;
                }
                break;
            case 6: // ControlPages\RichEditBoxPage.xaml line 88
                {
                    this.fontColorButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.DropDownButton>(target);
                }
                break;
            case 7: // ControlPages\RichEditBoxPage.xaml line 155
                {
                    this.editor = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RichEditBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RichEditBox)this.editor).TextChanged += this.Editor_TextChanged;
                    ((global::Microsoft.UI.Xaml.Controls.RichEditBox)this.editor).GotFocus += this.Editor_GotFocus;
                }
                break;
            case 8: // ControlPages\RichEditBoxPage.xaml line 165
                {
                    this.findBoxLabel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 9: // ControlPages\RichEditBoxPage.xaml line 166
                {
                    this.findBox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 10: // ControlPages\RichEditBoxPage.xaml line 110
                {
                    global::Microsoft.UI.Xaml.Controls.Button element10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element10).Click += this.ColorButton_Click;
                }
                break;
            case 11: // ControlPages\RichEditBoxPage.xaml line 115
                {
                    global::Microsoft.UI.Xaml.Controls.Button element11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element11).Click += this.ColorButton_Click;
                }
                break;
            case 12: // ControlPages\RichEditBoxPage.xaml line 120
                {
                    global::Microsoft.UI.Xaml.Controls.Button element12 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element12).Click += this.ColorButton_Click;
                }
                break;
            case 13: // ControlPages\RichEditBoxPage.xaml line 125
                {
                    global::Microsoft.UI.Xaml.Controls.Button element13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element13).Click += this.ColorButton_Click;
                }
                break;
            case 14: // ControlPages\RichEditBoxPage.xaml line 130
                {
                    global::Microsoft.UI.Xaml.Controls.Button element14 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element14).Click += this.ColorButton_Click;
                }
                break;
            case 15: // ControlPages\RichEditBoxPage.xaml line 135
                {
                    global::Microsoft.UI.Xaml.Controls.Button element15 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element15).Click += this.ColorButton_Click;
                }
                break;
            case 16: // ControlPages\RichEditBoxPage.xaml line 140
                {
                    global::Microsoft.UI.Xaml.Controls.Button element16 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element16).Click += this.ColorButton_Click;
                }
                break;
            case 17: // ControlPages\RichEditBoxPage.xaml line 145
                {
                    global::Microsoft.UI.Xaml.Controls.Button element17 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element17).Click += this.ColorButton_Click;
                }
                break;
            case 18: // ControlPages\RichEditBoxPage.xaml line 36
                {
                    this.REBCustom = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.RichEditBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.RichEditBox)this.REBCustom).Loaded += this.REBCustom_Loaded;
                    ((global::Microsoft.UI.Xaml.Controls.RichEditBox)this.REBCustom).Unloaded += this.REBCustom_Unloaded;
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
            case 1: // ControlPages\RichEditBoxPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    RichEditBoxPage_obj1_Bindings bindings = new RichEditBoxPage_obj1_Bindings();
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

