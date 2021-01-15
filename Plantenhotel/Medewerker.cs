using System;
using System.Collections.Generic;

namespace Plantenhotel
{
    public record Medewerker
        (
            string Achternaam,
            string Voornaam,
            DateTime Geboortedatum,
            string Gsmnr,
            string Emailadres,
            string Gebruikersnaam,
            string Wachtwoord
        ) : Persoon( Achternaam, Voornaam, Geboortedatum, Gsmnr, Emailadres, Gebruikersnaam, Wachtwoord )
    {
        // velden

        // methoden op instance-niveau


    }
}
