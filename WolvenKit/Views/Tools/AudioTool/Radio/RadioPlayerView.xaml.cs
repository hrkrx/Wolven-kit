﻿
using WolvenKit.ViewModels.AudioTool.Radio;

namespace WolvenKit.Views.AudioTool.Radio
{
    public partial class RadioPlayerView
    {

        public RadioPlayerView()
        {
            InitializeComponent(); 
   


        }

        private void PauseButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void PlayButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {


        }

        private void StopButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        public void LoadRadio(string path)
        {
          

         
    
        }

     

        private void OpenFile()
        {
      
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Radio Player");
            }
        }
    }
}
