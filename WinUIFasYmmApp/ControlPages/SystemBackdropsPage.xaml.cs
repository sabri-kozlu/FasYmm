//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using WinUIFasYmmApp.Helper;
using System;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace WinUIFasYmmApp.ControlPages
{
    public sealed partial class SystemBackdropsPage : Page
    {
        public SystemBackdropsPage()
        {
            this.InitializeComponent();
        }

        private void createBuiltInMicaWindow_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new WinUIFasYmmApp.SamplePages.SampleBuiltInSystemBackdropsWindow();
            newWindow.Activate();
        }

        private void createCustomMicaWindow_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new WinUIFasYmmApp.SamplePages.SampleSystemBackdropsWindow();
            newWindow.SetBackdrop(WinUIFasYmmApp.SamplePages.SampleSystemBackdropsWindow.BackdropType.Mica);
            newWindow.Activate();
        }

        private void createBuiltInAcrylicWindow_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new WinUIFasYmmApp.SamplePages.SampleSystemBackdropsWindow();
            newWindow.SetBackdrop(WinUIFasYmmApp.SamplePages.SampleSystemBackdropsWindow.BackdropType.DesktopAcrylicBase);
            newWindow.Activate();
        }

        private void createCustomDesktopAcrylicWindow_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new WinUIFasYmmApp.SamplePages.SampleSystemBackdropsWindow();
            newWindow.SetBackdrop(WinUIFasYmmApp.SamplePages.SampleSystemBackdropsWindow.BackdropType.DesktopAcrylicBase);
            newWindow.Activate();
        }
    }
}
