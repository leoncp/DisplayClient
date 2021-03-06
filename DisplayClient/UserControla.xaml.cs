﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DisplayClient
{
    /// <summary>
    /// Interaction logic for UserControla.xaml
    /// </summary>
    public partial class UserControla : UserControl
    {

        public static int MediaStateA = 0; //0 inactive, 1 playing, 2 mediaended
        public static int MediaStateB = 0; //0 inactive, 1 playing, 2 mediaended
        //public static string CurrentMediaPlayer = "a";

        public UserControla()
        {
            InitializeComponent();
        }

        private void mediaElementA_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaStateA = 2;
            e.Handled = true;
        }

        private void mediaElementA_MediaOpened(object sender, RoutedEventArgs e)
        {
            MediaStateA = 1; MediaStateB = 0;
            mediaElementA.Visibility = Visibility.Visible;
            mediaElementB.Visibility = Visibility.Hidden;
            mediaElementB.Source = null;
            e.Handled = true;
        }

        private void mediaElementB_MediaEnded(object sender, System.Windows.RoutedEventArgs e)
        {
        	MediaStateB = 2;
            e.Handled = true;
        }

        private void mediaElementB_MediaOpened(object sender, System.Windows.RoutedEventArgs e)
        {
            MediaStateB = 1; MediaStateA = 0;
            mediaElementB.Visibility = Visibility.Visible;
            mediaElementA.Visibility = Visibility.Hidden;
            mediaElementA.Source = null;
            e.Handled = true;
        }
    }
}
