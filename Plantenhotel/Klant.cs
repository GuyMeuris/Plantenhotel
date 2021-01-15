using System;
using System.Collections.Generic;

namespace Plantenhotel
{
    public record Klant
        (
            string Achternaam,
            string Voornaam,
            DateTime Geboortedatum,
            string Gsmnr,
            string Emailadres,
            string Gebruikersnaam,
            string Wachtwoord,
            DateTime KlantSinds

        ) : Persoon( Achternaam, Voornaam, Geboortedatum, Gsmnr, Emailadres, Gebruikersnaam, Wachtwoord )
    {
        // velden
        private int aantalBestellingen = 0;
        private bool isParticulier = true;
        private string BTWnr = "n.v.t.";

        // constructor

        // methoden op instance-niveau

        // methoden op record-niveau

    }

}
