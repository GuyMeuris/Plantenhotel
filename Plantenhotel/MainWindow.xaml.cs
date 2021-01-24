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

        
        private void ListViewItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // set tooltip visibility

            if (tg_btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_Registratie.Visibility = Visibility.Collapsed;
                tt_Login.Visibility = Visibility.Collapsed;
                tt_Offerte.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_Registratie.Visibility = Visibility.Visible;
                tt_Login.Visibility = Visibility.Visible;
                tt_Offerte.Visibility = Visibility.Visible;
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Home();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Login();
        }

        private void Registratie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Registratie();
        }

        

        private void Offerte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Contact();
        }
    }
}
