using System;

namespace Plantenhotel
{
    public abstract record Persoon
        (
        string Achternaam,
        string Voornaam,
        DateTime Geboortedatum,
        string Gsmnr,
        string Emailadres,
        string Gebruikersnaam,
        string Wachtwoord
        )

    {
        // velden
        protected static int Persoon_ID = 0;

        //properties
        public string Naam { get => $"{Voornaam} {Achternaam}"; }


    }



}
