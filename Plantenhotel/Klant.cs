using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            
        }



        #endregion
    }

}
