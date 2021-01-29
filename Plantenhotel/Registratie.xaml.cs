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
    /// Interaction logic for Registratie.xaml
    /// </summary>
    public partial class Registratie : Page
    {
        public Registratie()
        {
            InitializeComponent();
        }


        public void regbtn_Click(object sender, RoutedEventArgs e)
        {


            // gegevens
            try
            {
                //System.IO.FileStream gegevensKlant;
                //byte[] gegevens = null;
                //gegevens = Encoding.ASCII.GetBytes(achnaam.Text + vrnaam.Text + straat.Text + nr.Text + postcode.Text + stad.Text + gsm.Text + geboorte.Text + mail.Text + Environment.NewLine);
                //gegevensKlant = new FileStream("Tekstbestanden/gegevensKlant.txt", FileMode.Append);
                //gegevensKlant.Write(gegevens, 0, gegevens.Length);
                //gegevensKlant.Close();
                Klant k = new Klant(achnaam.Text, vrnaam.Text, geboorte.Text, nr.Text, mail.Text, gebrnaam.Text, wwoord.Text);

            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }



            MessageBox.Show("U bent geregistreerd. Weet dat uw planten veilig zijn in onze handen.");



            //naar login pagina
            Login nextPage = new Login();
            NavigationService.Navigate(nextPage);

        }
    }

}
