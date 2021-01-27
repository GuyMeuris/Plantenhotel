﻿using System;
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
                //KanInloggen(_gebruiker, _wachtwoord);
                StreamReader sr = new StreamReader(@"C:\Visual Studio Repos\GebruikersnaamWachtwoord.txt");
                string components = sr.ReadToEnd();
                //components splitsen naar array
                String[] regels = components.Split("\n");
                sr.Close();

                foreach (var item in regels)
                {
                    string separator = " ";
                    string item2 = item.Trim();
                    int separatorIndex = item2.IndexOf(separator);
                    if (separatorIndex > 0)
                    {
                        string gebruikersnaam = item2.Substring(0, separatorIndex);
                        gebruikers.Add(gebruikersnaam);
                        string wachtwoord = item2.Substring(separatorIndex + 1);
                        wachtwoorden.Add(wachtwoord);
                    }
                }
                string user = tbGebruikersnaam.Text.Trim();
                string paswoord = tbWachtwoord.Password.Trim();
                if (gebruikers.Contains(user) && wachtwoorden.Contains(paswoord)
                    && gebruikers.IndexOf(user) == wachtwoorden.IndexOf(paswoord))
                {
                    MessageBox.Show("U bent ingelogd, welkom!");
                    DisplayWindow(new Klantenmenu());

                }
                else

                    MessageBox.Show("Gebruikersnaam of wachtwoord is niet juist, probeer opnieuw a.u.b.!");

            }
        }
    }
}
