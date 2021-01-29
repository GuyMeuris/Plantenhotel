using System.Windows.Controls;

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : Page
    {
        private int keuzeIndex = 0;

        public Overview()
        {
            InitializeComponent();

            ShowSerre();
        }

        private void SerreKiezenMin_Click( object sender, System.Windows.RoutedEventArgs e )
        {
            keuzeIndex--;
            if ( keuzeIndex == -1 )
            {
                keuzeIndex = Serre.lijstSerres.Count - 1;
            }
            ShowSerre();
        }

        private void SerreKiezen_Plus( object sender, System.Windows.RoutedEventArgs e )
        {
            keuzeIndex++;
            if ( keuzeIndex == Serre.lijstSerres.Count )
            {
                keuzeIndex = 0;
            }
            ShowSerre();
        }

        private void ShowSerre()
        {
            naamSerre.DataContext = Serre.lijstSerres[keuzeIndex];
            grootteSerre.DataContext = Serre.lijstSerres[keuzeIndex];
            hoogteSerre.DataContext = Serre.lijstSerres[keuzeIndex];
            tempSerre.DataContext = Serre.lijstSerres[keuzeIndex];
            vochtigheidSerre.DataContext = Serre.lijstSerres[keuzeIndex];
            vrijeRuimteSerre.DataContext = Serre.lijstSerres[keuzeIndex];
        }
    }
}
