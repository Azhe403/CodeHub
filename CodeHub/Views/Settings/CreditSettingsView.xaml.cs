﻿using CodeHub.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace CodeHub.Views 
{
    public sealed partial class CreditSettingsView : SettingsDetailPageBase
    {
        private SettingsViewModel ViewModel;

        public CreditSettingsView()
        {
            this.InitializeComponent();
            ViewModel = new SettingsViewModel();
            this.DataContext = ViewModel;
        }

        private void OnCurrentStateChanged(object sender, VisualStateChangedEventArgs e)
        {
            if (e.NewState != null)
                TryNavigateBackForDesktopState(e.NewState.Name);
        }
    }
}
