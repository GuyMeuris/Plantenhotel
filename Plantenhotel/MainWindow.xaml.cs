/* Groepswerk WPF app: "Plantenhotel"
 * Deelnemers: Nina Roland, Benjamin Donck, Nigel De Maeght, Guy Meuris
 * Gemaakt in januari 2021

   Deze app (wanneer helemaal functioneel) geeft een oplossing voor 
   bedrijven die een plantenhotel uitbaten.
*/

using System.Windows;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            Medewerker medewerker1 = new Medewerker( "Janssens", "Jan", "12/03/1965",
                "0476826597", "Jan.janssens@gemeel.com", "medewerker1", "mw1" );
            Medewerker medewerker2 = new Medewerker( "Peeters", "Peter", "02/03/1971",
                "0476823197", "Peter.Peeters@gemeel.com", "medewerker2", "mw2" );
            Medewerker medewerker3 = new Medewerker( "Franken", "Frank", "25/09/1975",
                "0472144597", "Frank.Franken@gemeel.com", "medewerker3", "mw3" );
            Medewerker medewerker4 = new Medewerker( "Willems", "Willem", "11/08/2000",
                "0478888888", "Jan.janssens@gemeel.com", "medewerker4", "mw4" );

            Klant klant1 = new Klant
                ( "Aap", "Jos", "01/02/1999", "0496999999",
                                       "aaa@bbb.com", "gebruiker1", "ww1" );
            Klant klant2 = new Klant
                ( "Peeters", "Kos", "01/03/1999", "0496999998",
                                       "abb@bbb.com", "gebruiker2", "ww2" );
            Klant klant3 = new Klant( "Cap", "Dos", "01/04/1999",
                    "0496999997", "acc@bbb.com", "gebruiker3", "ww3" );
            Klant klant4 = new Klant( "Dap", "Mos", "01/05/1999",
                         "0496999996", "add@bbb.com", "gebruiker4", "ww4" );

            Serre serre1 = new Serre( "Serre1", 200, 5, 22, 70 );
            serre1.HuidigeTemp = 21;
            serre1.HuidigeVochtigheid = 71;
            serre1.VrijeRuimte = 45;
            Serre serre2 = new Serre( "Serre2", 100, 3, 22, 70 );
            serre2.HuidigeTemp = 25;
            serre2.HuidigeVochtigheid = 70;
            serre2.VrijeRuimte = 25;
            Serre serre3 = new Serre( "Serre3", 200, 5, 17, 55 );
            serre3.HuidigeTemp = 20;
            serre3.HuidigeVochtigheid = 55;
            serre3.VrijeRuimte = 125;
            Serre serre4 = new Serre( "Serre4", 100, 3, 17, 55 );
            serre4.HuidigeTemp = 22;
            serre4.HuidigeVochtigheid = 70;
            serre4.VrijeRuimte = 55;

        }

        private void Home_Loaded( object sender, RoutedEventArgs e )
        {
            MainFrame.NavigationService.Navigate( new Home() );
        }


        private void ListViewItem_MouseEnter( object sender, System.Windows.Input.MouseEventArgs e )
        {
            // set tooltip visibility

            if ( tg_btn.IsChecked == true )
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_Registratie.Visibility = Visibility.Collapsed;
                tt_Login.Visibility = Visibility.Collapsed;
                tt_Offerte.Visibility = Visibility.Collapsed;
                tt_Info.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_Registratie.Visibility = Visibility.Visible;
                tt_Login.Visibility = Visibility.Visible;
                tt_Offerte.Visibility = Visibility.Visible;
                tt_Info.Visibility = Visibility.Visible;
            }
        }

        private void Home_Click( object sender, RoutedEventArgs e )
        {
            // MainFrame.Content = new Home();
            MainFrame.NavigationService.Navigate( new Home() );
            tg_btn.IsChecked = false;
        }

        private void Login_Click( object sender, RoutedEventArgs e )
        {
            // MainFrame.Content = new Login();
            MainFrame.NavigationService.Navigate( new Login() );
            tg_btn.IsChecked = false;
        }

        private void Registratie_Click( object sender, RoutedEventArgs e )
        {
            // MainFrame.Content = new Registratie();
            MainFrame.NavigationService.Navigate( new Registratie() );
            tg_btn.IsChecked = false;
        }

        private void Offerte_Click( object sender, RoutedEventArgs e )
        {
            // MainFrame.Content = new Offerte();
            MainFrame.NavigationService.Navigate( new OfferteAanvraag() );
            tg_btn.IsChecked = false;
        }

        private void Info_Click( object sender, RoutedEventArgs e )
        {
            // MainFrame.Content = new Info();
            MainFrame.NavigationService.Navigate( new Info() );
            tg_btn.IsChecked = false;
        }

        private void Close_Btn_Click( object sender, RoutedEventArgs e )
        {
            Application.Current.Shutdown();
        }
    }
}
