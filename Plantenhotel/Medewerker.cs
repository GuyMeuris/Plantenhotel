using System;

namespace Plantenhotel
{
    public class Medewerker : Persoon
    {
        #region Constructor

        public Medewerker( string achternaam, string voornaam,
                            DateTime geboortedatum, string gsmnr,
                                    string email, string gebruikersnaam,
                                            string wachtwoord ) :
            base( achternaam, voornaam, geboortedatum, gsmnr, email, gebruikersnaam, wachtwoord )
        {

        }

        #endregion




    }
}
