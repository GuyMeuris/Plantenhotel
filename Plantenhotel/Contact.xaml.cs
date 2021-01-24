using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Contact.xaml
    /// </summary>
    public partial class Contact : Page
    {

        public Contact()
        {
            InitializeComponent();
        }

        private void NaamBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            naamBedrijf.Content = DisplayBedrijfsinfo( 0 );
        }

        private void StraatBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            straatBedrijf.Content = DisplayBedrijfsinfo( 1 );
        }

        private void HuisnummerBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            huisnummerBedrijf.Content = DisplayBedrijfsinfo( 2 );
        }

        private void PostcodeBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            postcodeBedrijf.Content = DisplayBedrijfsinfo( 3 );
        }

        private void StadBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            stadBedrijf.Content = DisplayBedrijfsinfo( 4 );
        }

        private void LandBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            landBedrijf.Content = DisplayBedrijfsinfo( 5 );
        }

        private void BTWBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            BTWBedrijf.Content = DisplayBedrijfsinfo( 6 );
        }

        private void IBANBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            IBANBedrijf.Content = DisplayBedrijfsinfo( 7 );
        }

        private void EmailBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            emailBedrijf.Content = DisplayBedrijfsinfo( 8 );
        }

        private void UrlBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            urlBedrijf.Content = DisplayBedrijfsinfo( 9 );
        }

        private void TelBedrijf_Loaded( object sender, RoutedEventArgs e )
        {
            telBedrijf.Content = DisplayBedrijfsinfo( 10 );
        }

        private string DisplayBedrijfsinfo( int i )
        {
            string[] regels;
            string resultaat = String.Empty;
            try
            {
                string dir = @"C:\Users\guy\Source\Repos\GuyMeuris\Plantenhotel\Plantenhotel\Tekstbestanden\DeSchuurGegevens.txt";
                using StreamReader sr = new StreamReader( dir );
                string tekst = sr.ReadLine();
                regels = tekst.Split( ";" );
                resultaat = regels[i];
            }
            catch
            {
                MessageBox.Show( "Het bestand kon niet worden gelezen!" );
            }
            return resultaat;
        }
    }
}
