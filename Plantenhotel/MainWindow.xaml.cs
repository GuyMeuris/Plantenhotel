/* Groepswerk WPF app: "Plantenhotel"
 * Deelnemers: Nina Roland, Benjamin Donck, Nigel De Maeght, Guy Meuris
 * Gemaakt in januari 2021

   Deze app geeft een oplossing voor bedrijven die een plantenhotel uitbaten.
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
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Home.Content = new Login();
        }

        private void Button_Click2( object sender, RoutedEventArgs e )
        {
            Home.Content = new OfferteAanvraag();
        }

        private void Button_Click3( object sender, RoutedEventArgs e )
        {
            Home.Content = new Registratie();
        }

        private void ContactBtn_Click( object sender, RoutedEventArgs e )
        {
            Home.Content = new Contact();
        }
    }
}
