﻿
using Catel.Windows;
using Sample_NAudio;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WolvenKit.ViewModels.AudioTool;
using WPFSoundVisualizationLib;

namespace WolvenKit.Views.AudioTool
{
    public partial class AudioToolView
    {

        public AudioToolView() : base(DataWindowMode.Custom)
        {
            InitializeComponent();




            GivenRedAudioSource.Add("Red");
            GivenRedAudioSource.Add("Blue");
            GivenRedAudioSource.Add("Green");
            GivenRedAudioSource.Add("Orange");
            GivenRedAudioSource.Add("Purple");
            GivenRedAudioSource.Add("White");
            GivenRedAudioSource.Add("Black");
            PlayListView.ItemsSource = GivenRedAudioSource;


            ResourceDictionary themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
            //clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromMilliseconds(channel.CurrentSound.GetLength(TimeUnit.MS)));
           // this.DataContext = new AudioToolViewModel();


            NAudioEngine soundEngine = NAudioEngine.Instance;
            soundEngine.PropertyChanged += NAudioEngine_PropertyChanged;

           // UIHelper.Bind(soundEngine, "CanStop", StopButton, Button.IsEnabledProperty);
           // UIHelper.Bind(soundEngine, "CanPlay", PlayButton, Button.IsEnabledProperty);
           // UIHelper.Bind(soundEngine, "CanPause", PauseButton, Button.IsEnabledProperty);
      

            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            waveformTimeline.RegisterSoundPlayer(soundEngine);

            //LoadExpressionDarkTheme();
            ShowPage();
        }


        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Hidden);

                    break;
                case 1:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    break;
                case 2:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    break;
                case 3:
                    StepOne.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepTwo.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepThree.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    StepFour.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    break;
            }
        }

        private void NextPage(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Next();
            ShowPage();
        }

        private void PreviousPage(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Prev();
            ShowPage();
        }

        #region NAudio Engine Events
        private void NAudioEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NAudioEngine engine = NAudioEngine.Instance;
            switch (e.PropertyName)
            {
                case "FileTag":
                    if (engine.FileTag != null)
                    {
                        TagLib.Tag tag = engine.FileTag.Tag;
                        if (tag.Pictures.Length > 0)
                        {
                            using (MemoryStream albumArtworkMemStream = new MemoryStream(tag.Pictures[0].Data.Data))
                            {
                                try
                                {
                                    BitmapImage albumImage = new BitmapImage();
                                    albumImage.BeginInit();
                                    albumImage.CacheOption = BitmapCacheOption.OnLoad;
                                    albumImage.StreamSource = albumArtworkMemStream;
                                    albumImage.EndInit();
                                }
                                catch (NotSupportedException)
                                {
                                    // System.NotSupportedException:
                                    // No imaging component suitable to complete this operation was found.
                                }
                                albumArtworkMemStream.Close();
                            }
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                    break;
                case "ChannelPosition":
                    clockDisplay.SetCurrentValue(WPFSoundVisualizationLib.DigitalClock.TimeProperty, TimeSpan.FromSeconds(engine.ChannelPosition));
                    break;
                default:
                    // Do Nothing
                    break;
            }

        }
        #endregion

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanPause)
                NAudioEngine.Instance.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanStop)
                NAudioEngine.Instance.Stop();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void LoadDefaultTheme()
        {


            Resources.MergedDictionaries.Clear();
        }

        private void LoadDarkBlueTheme()
        {
      

            Resources.MergedDictionaries.Clear();
            ResourceDictionary themeResources = Application.LoadComponent(new Uri("DarkBlue.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void LoadExpressionDarkTheme()
        {
     

            Resources.MergedDictionaries.Clear();
            ResourceDictionary themeResources = Application.LoadComponent(new Uri("ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void LoadExpressionLightTheme()
        {
          

            Resources.MergedDictionaries.Clear();
            ResourceDictionary themeResources = Application.LoadComponent(new Uri("ExpressionLight.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(themeResources);
        }

        private void DefaultThemeMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //LoadDefaultTheme();
        }

        private void ExpressionDarkMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //LoadExpressionDarkTheme();
        }

        private void ExpressionLightMenuItem_Checked(object sender, RoutedEventArgs e)
        {
          //  LoadExpressionLightTheme();
        }

        private void OpenFile()
        {
            Microsoft.Win32.OpenFileDialog openDialog = new Microsoft.Win32.OpenFileDialog();
            openDialog.Filter = "(*.mp3)|*.mp3";
            if (openDialog.ShowDialog() == true)
            {
                NAudioEngine.Instance.OpenFile(openDialog.FileName);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                RunnerText.SetCurrentValue(ContentProperty, openDialog.FileName);
            }
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            NAudioEngine.Instance.Dispose();
        }




        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NAudioEngine.Instance.Dispose();
            if (NAudioEngine.Instance.CanStop)
                NAudioEngine.Instance.Stop();
            this.Close();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            SetCurrentValue(WindowStateProperty, System.Windows.WindowState.Minimized);
        }


        public ObservableCollection<string> GivenRedAudioSource = new ObservableCollection<string>();

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Audio Tool");
            }
        }
    }

}
