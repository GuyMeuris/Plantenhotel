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
        public static List<Klant> lijstKlanten = new List<Klant>();
        private int aantalBestellingen = 0;
        private bool isParticulier = true;
        private string BTWnr = "n.v.t.";

        // constructor

        // methoden op instance-niveau

        // methoden op record-niveau
        public static void ToonNamenAlleKlanten()
        {
            Console.Write( "Alle geregistreerde klanten:" );
            for ( int i = 0; i <= lijstKlanten.Count - 1; i++ )
            {
                Console.Write( $"{(i == 0 ? " " : "")}{lijstKlanten[i].Naam}{(i == lijstKlanten.Count - 2 ? " en " : "")}" +
                                $"{ (i < lijstKlanten.Count - 2 ? ", " : "")}" );
            }
            Console.WriteLine( "." );
        }

    }

}
