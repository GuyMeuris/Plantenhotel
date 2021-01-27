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

            Info = @"Als u zich, net als wij, zorgen maakt over hoe
uw kamerplanten zullen overleven terwijl u op 
vakantie bent, vrees dan niet, want PlantenB&B 
""De Schuur"" is hier om uw planten levend en 
gezond te houden in een '5-sterren all-inclusive' 
botanisch hotel.
Online reserveren kan al vanaf 3 planten en wij 
komen ze zelfs bij u thuis ophalen én terugbrengen!
Als u bij ons boekt, worden uw planten verzorgd
door een team van specialisten, zodat ze geliefd 
en gehydrateerd blijven terwijl u geniet van een 
onbezorgde vakantie zonder schuldgevoel. U wordt 
zelfs uitgenodigd om de persoonlijkheidskenmerken
en specifieke behoeften van uw planten te delen
om ervoor te zorgen dat ze de allerbeste zorg 
krijgen.";
        }

        private void Home_Load( object sender, RoutedEventArgs e )
        {
            naamBedrijf.Content = DisplayBedrijfsinfo( 0, ";" );

            // infoBedrijf.Text = DisplayBedrijfsinfo( 1, "Bedrijfsinfo:" );
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
