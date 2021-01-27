using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public string Info { get; set; }



        public Home()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Home_Load( object sender, RoutedEventArgs e )
        {
            naamBedrijf.Content = DisplayBedrijfsinfo( 0, ";" );

            infoBedrijf.Text = DisplayBedrijfsinfo( 1, "Bedrijfsinfo:" );

        }

        private static string DisplayBedrijfsinfo( int i, string separator )
        {

            string[] regels;
            string resultaat = String.Empty;
            try
            {
                string dir = "Tekstbestanden/DeSchuurGegevens.txt";
                using StreamReader sr = new StreamReader( dir );
                string tekst = sr.ReadToEnd();
                regels = tekst.Split( separator );
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
