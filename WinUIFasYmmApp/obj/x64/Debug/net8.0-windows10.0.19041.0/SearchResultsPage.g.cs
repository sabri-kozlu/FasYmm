﻿#pragma checksum "C:\Users\sabri\Desktop\FasWebAPI\dev2ninovasyon\WinUIFasYmmAppV1\WinUIFasYmmApp\SearchResultsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87C0FFDCF2F02BB54D26F883964F06C9288FA51784CD64AFCF7A36FF5B9AE134"
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
    partial class SearchResultsPage : 
        global::WinUIFasYmmApp.ItemsPageBase, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_NavigationView_MenuItemsSource(global::Microsoft.UI.Xaml.Controls.NavigationView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.MenuItemsSource = value;
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
        private partial class SearchResultsPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISearchResultsPage_Bindings
        {
            private global::WinUIFasYmmApp.SearchResultsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.NavigationView obj8;
            private global::Microsoft.UI.Xaml.Controls.GridView obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8MenuItemsSourceDisabled = false;
            private static bool isobj10ItemsSourceDisabled = false;

            private SearchResultsPage_obj1_BindingsTracking bindingsTracking;

            public SearchResultsPage_obj1_Bindings()
            {
                this.bindingsTracking = new SearchResultsPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 51 && columnNumber == 13)
                {
                    isobj8MenuItemsSourceDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 21)
                {
                    isobj10ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // SearchResultsPage.xaml line 45
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationView>(target);
                        break;
                    case 10: // SearchResultsPage.xaml line 55
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.GridView>(target);
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

            // ISearchResultsPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::WinUIFasYmmApp.SearchResultsPage>(newDataRoot);
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
            private void Update_(global::WinUIFasYmmApp.SearchResultsPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Filters(obj.Filters, phase);
                        this.Update_resultsNavView(obj.resultsNavView, phase);
                    }
                }
            }
            private void Update_Filters(global::System.Collections.Generic.IEnumerable<global::WinUIFasYmmApp.Filter> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SearchResultsPage.xaml line 45
                    if (!isobj8MenuItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_NavigationView_MenuItemsSource(this.obj8, obj, null);
                    }
                }
            }
            private void Update_resultsNavView(global::Microsoft.UI.Xaml.Controls.NavigationView obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_resultsNavView(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_resultsNavView_SelectedItem(obj.SelectedItem, phase);
                    }
                }
            }
            private void Update_resultsNavView_SelectedItem(global::System.Object obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter((global::WinUIFasYmmApp.Filter)obj, phase);
                    }
                }
            }
            private void Update_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter(global::WinUIFasYmmApp.Filter obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter_Items(obj.Items, phase);
                    }
                }
            }
            private void Update_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter_Items(global::System.Collections.Generic.List<global::WinUIFasYmmApp.Data.ControlInfoDataItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SearchResultsPage.xaml line 55
                    if (!isobj10ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SearchResultsPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SearchResultsPage_obj1_Bindings> weakRefToBindingObj; 

                public SearchResultsPage_obj1_BindingsTracking(SearchResultsPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SearchResultsPage_obj1_Bindings>(obj);
                }

                public SearchResultsPage_obj1_Bindings TryGetBindingObject()
                {
                    SearchResultsPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_resultsNavView(null);
                    UpdateChildListeners_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SearchResultsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::WinUIFasYmmApp.SearchResultsPage obj = sender as global::WinUIFasYmmApp.SearchResultsPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Filters(obj.Filters, DATA_CHANGED);
                                bindings.Update_resultsNavView(obj.resultsNavView, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Filters":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Filters(obj.Filters, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::WinUIFasYmmApp.SearchResultsPage obj)
                {
                    SearchResultsPage_obj1_Bindings bindings = TryGetBindingObject();
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
                public void DependencyPropertyChanged_resultsNavView_SelectedItem(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    SearchResultsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.NavigationView obj = sender as global::Microsoft.UI.Xaml.Controls.NavigationView;
                        if (obj != null)
                        {
                            bindings.Update_resultsNavView_SelectedItem(obj.SelectedItem, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.NavigationView cache_resultsNavView = null;
                private long tokenDPC_resultsNavView_SelectedItem = 0;
                public void UpdateChildListeners_resultsNavView(global::Microsoft.UI.Xaml.Controls.NavigationView obj)
                {
                    if (obj != cache_resultsNavView)
                    {
                        if (cache_resultsNavView != null)
                        {
                            cache_resultsNavView.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.NavigationView.SelectedItemProperty, tokenDPC_resultsNavView_SelectedItem);
                            cache_resultsNavView = null;
                        }
                        if (obj != null)
                        {
                            cache_resultsNavView = obj;
                            tokenDPC_resultsNavView_SelectedItem = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.NavigationView.SelectedItemProperty, DependencyPropertyChanged_resultsNavView_SelectedItem);
                        }
                    }
                }
                public void PropertyChanged_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SearchResultsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::WinUIFasYmmApp.Filter obj = sender as global::WinUIFasYmmApp.Filter;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter_Items(obj.Items, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Items":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter_Items(obj.Items, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::WinUIFasYmmApp.Filter cache_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter = null;
                public void UpdateChildListeners_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter(global::WinUIFasYmmApp.Filter obj)
                {
                    if (obj != cache_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter)
                    {
                        if (cache_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter).PropertyChanged -= PropertyChanged_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter;
                            cache_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter = null;
                        }
                        if (obj != null)
                        {
                            cache_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_resultsNavView_SelectedItem_Cast_SelectedItem_To_Filter;
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
            case 2: // SearchResultsPage.xaml line 14
                {
                    this.ResultStates = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualStateGroup>(target);
                }
                break;
            case 3: // SearchResultsPage.xaml line 24
                {
                    this.LayoutVisualStates = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualStateGroup>(target);
                }
                break;
            case 4: // SearchResultsPage.xaml line 25
                {
                    this.WideLayout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 5: // SearchResultsPage.xaml line 30
                {
                    this.NarrowLayout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 6: // SearchResultsPage.xaml line 15
                {
                    this.ResultsFound = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 7: // SearchResultsPage.xaml line 17
                {
                    this.NoResultsFound = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 8: // SearchResultsPage.xaml line 45
                {
                    this.resultsNavView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.resultsNavView).Loaded += this.OnResultsNavViewLoaded;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.resultsNavView).SelectionChanged += this.OnResultsNavViewSelectionChanged;
                }
                break;
            case 9: // SearchResultsPage.xaml line 74
                {
                    this.noResultsTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 10: // SearchResultsPage.xaml line 55
                {
                    this.resultsGridView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.GridView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.GridView)this.resultsGridView).ContainerContentChanging += this.OnItemGridViewContainerContentChanging;
                    ((global::Microsoft.UI.Xaml.Controls.GridView)this.resultsGridView).ItemClick += this.OnItemGridViewItemClick;
                    ((global::Microsoft.UI.Xaml.Controls.GridView)this.resultsGridView).Loaded += this.OnItemGridViewLoaded;
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
            case 1: // SearchResultsPage.xaml line 1
                {                    
                    global::WinUIFasYmmApp.ItemsPageBase element1 = (global::WinUIFasYmmApp.ItemsPageBase)target;
                    SearchResultsPage_obj1_Bindings bindings = new SearchResultsPage_obj1_Bindings();
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

