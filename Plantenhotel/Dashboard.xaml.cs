using System.Windows;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Home_Loaded( object sender, RoutedEventArgs e )
        {
            MenuFrame.NavigationService.Navigate( new Overview() );
        }
    }
}
