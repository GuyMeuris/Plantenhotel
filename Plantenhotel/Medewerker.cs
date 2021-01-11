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
        public List<Medewerker> lijstMedewerkers = new List<Medewerker>();

        // constructor

        // methoden op instance-niveau
        public void ToonNamenAlleMedewerkers()
        {
            Console.Write( "Alle ingeschreven deelnemers:" );
            for ( int i = 0; i <= lijstMedewerkers.Count - 1; i++ )
            {
                Console.Write( $"{(i == 0 ? " " : "")}{lijstMedewerkers[i].Naam}{(i == lijstMedewerkers.Count - 2 ? " en " : "")}" +
                                $"{ (i < lijstMedewerkers.Count - 2 ? ", " : "")}" );
            }
            Console.WriteLine( "." );
        }


    }
}
