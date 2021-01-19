using System;

namespace Plantenhotel
{
    internal class Klant : Persoon
    {
        #region Velden
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

        /// <summary>
        /// Als klant particulier is, dan is de waarde true (default)
        /// Is de klant een bedrijf dan is de waarde false
        /// </summary>
        public bool isParticulier = true;

        /// <summary>
        /// Indien klant een bedrijf is, dan wordt hier de BTW-nr. bewaard
        /// </summary>
        public string BTWnr = "n.v.t.";

        #endregion

        #region Properties

        public int AantalBestellingen
        {
            get { return aantalBestellingen; }
            set
            {
                if ( value != aantalBestellingen )
                {
                    aantalBestellingen = value;
                    OnPropertyChanged( "AantalBestellingen" );
                }
            }
        }

        #endregion

        #region Constructors

        public Klant( string achternaam, string voornaam,
                            DateTime geboortedatum, string gsmnr,
                                    string email, string gebruikersnaam,
                                            string wachtwoord, bool isparticulier ) :
            base( achternaam, voornaam, geboortedatum, gsmnr, email, gebruikersnaam, wachtwoord )
        {
            isParticulier = isparticulier;
        }

        public Klant( string achternaam, string voornaam,
                            DateTime geboortedatum, string gsmnr,
                                    string email, string gebruikersnaam,
                                            string wachtwoord, bool isparticulier, string btwnr ) :
            base( achternaam, voornaam, geboortedatum, gsmnr, email, gebruikersnaam, wachtwoord )
        {
            isParticulier = isparticulier;
            BTWnr = btwnr;
        }

        #endregion
    }

}
