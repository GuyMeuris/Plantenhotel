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
using System.Security.Cryptography;


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
                System.IO.FileStream gegevensKlant;
                byte[] gegevens = null;
                gegevens = Encoding.ASCII.GetBytes(achnaam.Text + vrnaam.Text + straat.Text + nr.Text + postcode.Text + stad.Text + gsm.Text + geboorte.Text + mail.Text + Environment.NewLine);
                gegevensKlant = new FileStream("F:\\gegevensKlant.txt", FileMode.Append);
                gegevensKlant.Write(gegevens, 0, gegevens.Length);
                gegevensKlant.Close();
            }
            
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }


            
            //gebruikersnaam en wachtwoord
            try
            {
                

                System.IO.FileStream gebrww;
                byte[] gww = null;
                gww = Encoding.ASCII.GetBytes(gebrnaam.Text + wwoord.Text + Environment.NewLine);
                gebrww = new FileStream("F:\\GebruikersnaamWachtwoord.txt", FileMode.Append);
                

                gebrww.Write(gww, 0, gww.Length);
                
                gebrww.Close(); 
                

            }
            
            catch (IOException ex2)
            {
                MessageBox.Show(ex2.ToString());
            }



            //auto nr login pagina --> zien me nigel
        }

       

    }
}
