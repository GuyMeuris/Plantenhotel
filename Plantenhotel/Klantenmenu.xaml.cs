using System.Linq;
using System.Windows;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Klantenmenu.xaml
    /// </summary>
    public partial class Klantenmenu : Window
    {
        private int index;

        public Klantenmenu()
        {
            InitializeComponent();

           // index = ;
           // naamKlant.DataContext = Klant.lijstKlanten[index];

        }

        private void Klantenmenu_Loaded( object sender, RoutedEventArgs e )
        {
            MenuFrame.NavigationService.Navigate( new Menukeuze() );
        }

        private void Afsluiten_Click( object sender, RoutedEventArgs e )
        {
            Application.Current.Shutdown();
        }

        private void Home_Click( object sender, RoutedEventArgs e )
        {
            DisplayWindow( new MainWindow() );
        }

        private void DisplayWindow( Window windowToShow )
        {
            for ( int i = 0; i < Application.Current.Windows.OfType<Window>().
            Where( w => w.IsVisible ).Count(); i++ )
            {
                Window windowToHide = Application.Current.Windows[i];
                windowToHide.Visibility = Visibility.Collapsed;
            }
            windowToShow.Visibility = Visibility.Visible;
        }
    }
}
