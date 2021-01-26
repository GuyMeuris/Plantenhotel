using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Page
    {
        public Info()
        {
            InitializeComponent();
        }

        private void InfoPage_Load( object sender, RoutedEventArgs e )
        {
            naamBedrijf.Content = DisplayBedrijfsinfo( 0 );

            straatBedrijf.Content = DisplayBedrijfsinfo( 1 );

            huisnummerBedrijf.Content = DisplayBedrijfsinfo( 2 );

            postcodeBedrijf.Content = DisplayBedrijfsinfo( 3 );

            stadBedrijf.Content = DisplayBedrijfsinfo( 4 );

            landBedrijf.Content = DisplayBedrijfsinfo( 5 );

            BTWBedrijf.Content = DisplayBedrijfsinfo( 6 );

            IBANBedrijf.Content = DisplayBedrijfsinfo( 7 );

            emailBedrijf.Content = DisplayBedrijfsinfo( 8 );

            urlBedrijf.Content = DisplayBedrijfsinfo( 9 );

            telBedrijf.Content = DisplayBedrijfsinfo( 10 );
        }

        private static string DisplayBedrijfsinfo( int i )
        {

            string[] regels;
            string resultaat = String.Empty;
            try
            {
                string dir = "Tekstbestanden/DeSchuurGegevens.txt";
                using StreamReader sr = new StreamReader( dir );
                string tekst = sr.ReadToEnd();


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
