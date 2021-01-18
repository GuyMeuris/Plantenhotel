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
        private void Home_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Home();
        }



        private void Contactclick(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new Contact();
        }

        private void Login_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Login();
        }

        private void Registratie_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Registratie();
        }
    }
}
