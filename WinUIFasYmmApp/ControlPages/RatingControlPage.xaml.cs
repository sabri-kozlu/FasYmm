﻿using Microsoft.UI.Xaml.Controls;

namespace WinUIFasYmmApp.ControlPages
{
    public sealed partial class RatingControlPage : Page
    {
        public RatingControlPage()
        {
            this.InitializeComponent();
        }

        private void RatingControl1_ValueChanged(Microsoft.UI.Xaml.Controls.RatingControl sender, object args)
        {
            RatingControl1.Caption = "Your rating";
        }
    }
}
