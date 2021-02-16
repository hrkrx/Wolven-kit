﻿
namespace WolvenKit.Views.Wizards
{
    public partial class ThemeWizardView
    {
        public ThemeWizardView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Theme Wizard");
            }
        }
    }
}
