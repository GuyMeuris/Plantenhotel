using System.Collections.Generic;

namespace Plantenhotel
{
    public class Medewerker : Persoon
    {
        #region Velden op klasse-niveau

        public static List<Medewerker> lijstMedewerkers = new List<Medewerker>();

        #endregion

        #region Constructor

        public Medewerker( string achternaam, string voornaam,
                            string geboortedatum, string gsmnr,
                                    string email, string gebruikersnaam,
                                            string wachtwoord ) :
            base( achternaam, voornaam, geboortedatum, gsmnr, email, gebruikersnaam, wachtwoord )
        {
            lijstMedewerkers.Add( this );
        }

        #endregion

    }
}
