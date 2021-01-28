using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for OfferteAanvraag.xaml
    /// </summary>
    public partial class OfferteAanvraag : Page
    {
        int dagen = 0;

        bool snoei = false;

        bool mest = false;

        List<double> plantenOpp = new List<double>();

        double prijs = 0;

        int aantalPlantenAangemaakt = 1;

        public OfferteAanvraag()
        {
            InitializeComponent();
            prijskaartje.Content = $"{prijs}€";
            PlantNrText.Text = $"Omvang van de plant in m²: ";
        }

        // Radio buttons event handlers

        private void RadioSnoei_Checked(object sender, RoutedEventArgs e)
        {
            snoei = true;
        }

        private void RadioMest_Checked(object sender, RoutedEventArgs e)
        {
            mest = true;
        }

        private void RadioSnoei_Unckecked(object sender, RoutedEventArgs e)
        {
            snoei = false;
        }

        private void RadioMest_Unchecked(object sender, RoutedEventArgs e)
        {
            mest = false;
        }

        // plant toevoegen aan listbox + oppervlakte optellen

        private void PlantToevoegen_Click(object sender, RoutedEventArgs e)
        {

            string item = $"Plant {aantalPlantenAangemaakt} - {GroottePlant.Text}";

            // maak nieuwe listboxItem aan
            ListBoxItem lbi = new ListBoxItem();
            lbi.Content = item;
            // voeg listboxItem toe aan Listbox
            IngevoerdePlanten.Items.Add(lbi);

            // bij het aanmaken van de plant w de oppervlakte toegevoegd en aantalPlanten geïncrementeerd
            aantalPlantenAangemaakt++;
            plantenOpp.Add(Convert.ToDouble(GroottePlant.Text));
            GroottePlant.Text = string.Empty;

        }

        private void Krijg_Offerte_Click(object sender, RoutedEventArgs e)
        {

            dagen = Convert.ToInt32(aantalDagen.Text);

            if (snoei)
            {
                prijs += 20;
            }

            if (mest)
            {
                prijs += 10;
            }

            prijs = prijs + plantenOpp.Sum() * 2 * dagen;

            prijskaartje.Content = $"{prijs}€";

        }


    
}
}
