﻿
using ControlzEx.Theming;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class SelectThemeView
    {
        public SelectThemeView()
        {
            InitializeComponent();
        }

        private void ThemeColorsHoney_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private bool filled = false;
      

        private void Circle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var a = (Ellipse)sender;

            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, "Dark." + a.Name.ToString());


        }

        private void Circle_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = (Ellipse)sender;
            a.Fill = lastaccent;
        }
        private Brush lastaccent;
        private void Circle_MouseEnter(object sender, MouseEventArgs e)
        {
            var a = (Ellipse)sender;
            lastaccent = a.Fill;
            a.Fill = new SolidColorBrush(Colors.AliceBlue);
        }

      

       

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {

        }

        private void UserControl_Initialized_1(object sender, EventArgs e)
        {
            if (!filled)
            {

                (new Thread(() =>
                {



                    foreach (var Theme in ThemeManager.Current.Themes)
                    {
                        Thread.Sleep(15);
                        if (Theme.BaseColorScheme == "Dark")
                        {
                            if (!Theme.DisplayName.Contains("Colorful"))
                            {
                                if (!Theme.DisplayName.Contains('#'))
                                {
                                    Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                                    {

                                        Ellipse circle = new Ellipse();
                                        circle.Height = 25;
                                        circle.Width = 25;
                                        circle.Margin = new Thickness(5);
                                        circle.MouseEnter += Circle_MouseEnter;
                                        circle.MouseLeave += Circle_MouseLeave;
                                        circle.MouseLeftButtonDown += Circle_MouseLeftButtonDown;
                                        circle.Name = Theme.DisplayName.Split('(')[0].ToString().Trim();
                                        circle.Fill = Theme.ShowcaseBrush;

                                        CircleTest.Children.Add(circle);

                                    }));

                                }
                            
                            }
                        
                            




                        }
                    }
      


                })).Start();

            }
            filled = true;
        }
    }
}

