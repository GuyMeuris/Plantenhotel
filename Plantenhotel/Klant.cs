using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Plantenhotel
{
    internal class Klant : Persoon
    {
        #region Velden op klasse-niveau
        /// <summary>
        /// Hier worden alle klanteninstqnties bewaard
        /// </summary>

        public static List<Klant> lijstKlanten = new List<Klant>();

        #endregion

        #region Velden op instantie niveu
        /// <summary>
        /// Datum wanneer klant heeft geregistreerd op registratiepagina
        /// klantSinds = DateTime.Now() bij registratie
        /// </summary>
        public DateTime klantSinds;

        /// <summary>
        /// Aantal bestelling dat klant sinds begin al heeft geplaatst
        /// Beginwaarde is 0
        /// </summary>
        private int aantalBestellingen = 0;

        #endregion

        #region Properties

        public int AantalBestellingen
        {
            get { return aantalBestellingen; }
            set
            {
                if (value != aantalBestellingen)
                {
                    aantalBestellingen = value;
                    OnPropertyChanged("AantalBestellingen");
                }
            }
        }

        #endregion

        #region Constructors

        public Klant(string achternaam, string voornaam,
                            string geboortedatum, string gsmnr,
                                    string email, string gebruikersnaam,
                                            string wachtwoord) :
            base(achternaam, voornaam, geboortedatum, gsmnr, email, gebruikersnaam, wachtwoord)
        {
            lijstKlanten.Add(this);
            System.IO.FileStream klantGegevens;
            byte[] gegevens = null;
            gegevens = Encoding.ASCII.GetBytes(achternaam + ";" + voornaam + ";" + gsmnr + ";" + geboortedatum + ";" + email + ";" + Environment.NewLine);
            klantGegevens = new FileStream(@"..\..\..\Tekstbestanden\gegevensKlant.txt", FileMode.Append);
            klantGegevens.Write(gegevens, 0, gegevens.Length);
            klantGegevens.Close();

            System.IO.FileStream gebrww;
            byte[] gww = null;

            string encrGebruiker = AEScrypto.Encryptie(gebruikersnaam);
            string encrWachtwoord = AEScrypto.Encryptie(wachtwoord);
            gww = Encoding.ASCII.GetBytes(encrGebruiker + " " + encrWachtwoord + Environment.NewLine);
            gebrww = new FileStream(@"..\..\..\Tekstbestanden\GebruikersnaamWachtwoord.txt", FileMode.Append);
            gebrww.Write(gww, 0, gww.Length);
            
            gebrww.Close();
        }



        #endregion
    }

}
