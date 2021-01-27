using System.Windows;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Klantenmenu.xaml
    /// </summary>
    public partial class Klantenmenu : Window
    {
        public Klantenmenu()
        {
            InitializeComponent();
        }

        private void Klantenmenu_Loaded( object sender, RoutedEventArgs e )
        {
            MenuFrame.NavigationService.Navigate( new Menukeuze() );
        }
    }
}
