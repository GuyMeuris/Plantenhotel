using System;

namespace Plantenhotel
{
    public abstract class Persoon : ObservableObject

    {
        // Ik ga er van uit dat de velden voor zich spreken in deze Persoon-klasse.
        #region Velden

        private string achternaam;
        private string voornaam;
        private string geboortedatum;
        private string gsmNr;
        private string email;
        private string gebruikersnaam;
        private string wachtwoord;

        #endregion

        #region Properties

        /*
         * TerInfo: de 'PropertyChanged'-notificatie bestaat om de 'View' te informeren over
         * een verandering in waarde van een bepaalde property, zodat de 'View' deze aanpassing kan
         * implementeren. Ik zie code waarbij deze properties worden aangemaakt in de 'ViewModel', maar 
         * ik vind dit zelf 'complexer' en onnodig. Deze manier werkt (voorlopig) ook.
        */
        public string Achternaam
        {
            get { return achternaam; }
            set
            {
                if ( value != achternaam )
                {
                    achternaam = value;
                    OnPropertyChanged( "Achternaam" );
                }
            }
        }

        public string Voornaam
        {
            get { return voornaam; }
            set
            {
                if ( value != voornaam )
                {
                    voornaam = value;
                    OnPropertyChanged( "Voornaam" );
                }
            }
        }

        public string Geboortedatum
        {
            get { return geboortedatum; }
            set
            {
                if ( value != geboortedatum )
                {
                    geboortedatum = value;
                    OnPropertyChanged( "Geboortedatum" );
                }
            }
        }

        public string GsmNr
        {
            get { return gsmNr; }
            set
            {
                if ( value != gsmNr )
                {
                    gsmNr = value;
                    OnPropertyChanged( "Achternaam" );
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if ( value != email )
                {
                    email = value;
                    OnPropertyChanged( "Email" );
                }
            }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set
            {
                if ( value != gebruikersnaam )
                {
                    gebruikersnaam = value;
                    OnPropertyChanged( "Gebruikersnaam" );
                }
            }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set
            {
                if ( value != wachtwoord )
                {
                    wachtwoord = value;
                    OnPropertyChanged( "Wachtwoord" );
                }
            }
        }
        #endregion

        #region Constructor

        public Persoon( string achternaam, string voornaam, string geboortedatum, string gsmnr, string email, string gebruikersnaam, string wachtwoord )
        {
            Achternaam = achternaam;
            Voornaam = voornaam;
            Geboortedatum = geboortedatum;
            GsmNr = gsmnr;
            Email = email;
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
        }

        #endregion
    }



}
