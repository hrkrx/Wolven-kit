﻿
using WolvenKit.Views.SettingsPages.SubPages.Tool;

namespace WolvenKit.Views.SettingsPages
{
    public partial class ToolSettingsView
    {
        public ToolSettingsView()
        {
            ABSSV = new AssetBrowserSubSettingsView();
            PMSSV = new PluginManagerSubSettingsView();
            CESSV = new CodeEditorSubSettingsView();
            VESSV = new VisualEditorSubSettingsView();

            InitializeComponent();
        }

        private AssetBrowserSubSettingsView ABSSV;
        private PluginManagerSubSettingsView PMSSV;
        private CodeEditorSubSettingsView CESSV;
        private VisualEditorSubSettingsView VESSV;

        private void AssetBrowserSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(ABSSV);
            }
        }

        private void PluginManagerSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(PMSSV);
            }
        }

        private void CodeEditorSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(CESSV);
            }
        }

        private void VisualEditorSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(VESSV);
            }
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Setting - Tools");
            }
        }
    }
}
