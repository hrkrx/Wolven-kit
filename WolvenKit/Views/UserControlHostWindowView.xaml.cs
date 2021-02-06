﻿
using Catel.Windows;
using Catel.Windows.Controls;
using WolvenKit.ViewModels;

namespace WolvenKit.Views
{
    public partial class UserControlHostWindowView : DataWindow
    {
        public UserControlHostWindowView(UserControlHostWindowViewModel ucvm)
            : base(DataWindowMode.Custom)
        {
            InitializeComponent();

            UserContentControl.Content = ucvm.ContentUserControl;
            
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonClose(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonMinimize(object sender, System.Windows.RoutedEventArgs e)
        {
            SetCurrentValue(WindowStateProperty, System.Windows.WindowState.Minimized);
        }
    }
}
