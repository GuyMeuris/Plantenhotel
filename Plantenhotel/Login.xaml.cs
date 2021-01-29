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
using System.IO;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Klant dude;
        public Login()
        {
            InitializeComponent();
        }
        List<string> gebruikers = new List<string>();
        List<string> wachtwoorden = new List<string>();
        private void DisplayWindow(Window windowToShow)
        {
            for (int i = 0; i < Application.Current.Windows.OfType<Window>().
            Where(w => w.IsVisible).Count(); i++)
            {
                Window windowToHide = Application.Current.Windows[i];
                windowToHide.Visibility = Visibility.Collapsed;
            }
            windowToShow.Visibility = Visibility.Visible;
        }
        private void loginKnop_Click_1(object sender, RoutedEventArgs e)
        {
            if (tbGebruikersnaam.Text.Contains("DeSchuur") && tbWachtwoord.Password.Contains("Fotosynthese"))
            {
                MessageBox.Show("Welkom, collega!");
                DisplayWindow(new Dashboard());
            }
            else
            {
                string user = tbGebruikersnaam.Text.Trim();
                string paswoord = tbWachtwoord.Password.Trim();
                int a = Klant.lijstKlanten.FindIndex(e => e.Gebruikersnaam == user);
                int b = Klant.lijstKlanten.FindIndex(e => e.Wachtwoord == paswoord);

                if ((Klant.lijstKlanten.Exists(e => e.Gebruikersnaam == user)) && (Klant.lijstKlanten.Exists(e => e.Wachtwoord == paswoord))
                    && (Klant.lijstKlanten.FindIndex(e => e.Gebruikersnaam == user)) == Klant.lijstKlanten.FindIndex(e => e.Wachtwoord == paswoord))
                {
                    MessageBox.Show("U bent ingelogd, welkom!");


                    dude = Klant.lijstKlanten.Find(e => e.Gebruikersnaam == user);
                    //App.Current.Properties[dude.KlantID] = 
                    DisplayWindow(new Klantenmenu(dude));


                }
                else
                    MessageBox.Show("Gebruikersnaam of wachtwoord is niet juist, probeer opnieuw a.u.b.!");

            }
        }
    }
}
