﻿using System.Linq;
using System.Windows;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Home_Loaded( object sender, RoutedEventArgs e )
        {
            MenuFrame.NavigationService.Navigate( new Overview() );
        }

        private void Afsluiten_Click( object sender, RoutedEventArgs e )
        {
            Application.Current.Shutdown();
        }

        private void Home_Click( object sender, RoutedEventArgs e )
        {
            DisplayWindow( new MainWindow() );
        }

        private void DisplayWindow( Window windowToShow )
        {
            for ( int i = 0; i < Application.Current.Windows.OfType<Window>().
            Where( w => w.IsVisible ).Count(); i++ )
            {
                Window windowToHide = Application.Current.Windows[i];
                windowToHide.Visibility = Visibility.Collapsed;
            }
            windowToShow.Visibility = Visibility.Visible;
        }
    }
}
