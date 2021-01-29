using System.Collections.Generic;

namespace Plantenhotel
{
    /// <summary>
    /// In deze klasse worden instanties van de serres aangemaakt.
    /// In deze app gaan we uit van 4 bij de start aangemaakte serres:
    /// (Serre1, 200, 5, 22, 70)
    /// (Serre2, 100, 3, 22, 70)
    /// (Serre3, 200, 5, 17, 55)
    /// (Serre4, 100, 3, 17, 55)
    /// </summary>
    public class Serre : ObservableObject
    {
        #region Velden op klasse-niveau

        /// <summary>
        /// Hier worden alle serre-instanties bewaard
        /// </summary>
        public static List<Serre> lijstSerres = new List<Serre>();

        #endregion

        #region Velden op instantie-niveau

        /// <summary>
        /// Naam/ID van de serre (Serre1, Serre2, Serre3, Serre4)
        /// </summary>
        private string serre_ID;

        /// <summary>
        /// Grootte van de serre in m².
        /// </summary>
        private double grootte;

        /// <summary>
        /// Hoogte van de serre in meter.
        /// </summary>
        private double hoogte;

        /// <summary>
        /// Ruimte die overblijft met alle aanwezige planten.
        /// </summary>
        private double vrijeRuimte;

        /// <summary>
        /// Temperatuur in °C in deze serre op dit moment.
        /// </summary>
        private double huidigeTemp;

        /// <summary>
        /// De ideale temperatuur voor deze serre in °C.
        /// </summary>
        private double idealeTemp;

        /// <summary>
        /// Vochtigheidsgraad in % in deze serre op dit moment.
        /// </summary>
        private int huidigeVochtigheid;

        /// <summary>
        /// De ideale vochtigheidsgraad in % voor deze serre.
        /// </summary>
        private int idealeVochtigheid;

        #endregion

        #region Properties

        public string Serre_ID
        {
            get { return serre_ID; }
            set
            {
                if ( value != serre_ID )
                {
                    serre_ID = value;
                    OnPropertyChanged( "Serre_ID" );
                }
            }
        }

        public double Grootte
        {
            get { return grootte; }
            set
            {
                if ( value != grootte )
                {
                    grootte = value;
                    OnPropertyChanged( "Grootte" );
                }
            }
        }

        public double Hoogte
        {
            get { return hoogte; }
            set
            {
                if ( value != hoogte )
                {
                    hoogte = value;
                    OnPropertyChanged( "Hoogte" );
                }
            }
        }

        public double VrijeRuimte
        {
            get { return vrijeRuimte; }
            set
            {
                if ( value != vrijeRuimte )
                {
                    vrijeRuimte = value;
                    OnPropertyChanged( "VrijeRuimte" );
                }
            }
        }

        public double HuidigeTemp
        {
            get { return huidigeTemp; }
            set
            {
                if ( value != huidigeTemp )
                {
                    huidigeTemp = value;
                    OnPropertyChanged( "HuidigeTemp" );
                }
            }
        }

        public double IdealeTemp
        {
            get { return idealeTemp; }
            set
            {
                if ( value != idealeTemp )
                {
                    idealeTemp = value;
                    OnPropertyChanged( "IdealeTemp" );
                }
            }
        }

        public int HuidigeVochtigheid
        {
            get { return huidigeVochtigheid; }
            set
            {
                if ( value != huidigeVochtigheid )
                {
                    huidigeVochtigheid = value;
                    OnPropertyChanged( "HuidigeVochtigheid" );
                }
            }
        }

        public int IdealeVochtigheid
        {
            get { return idealeVochtigheid; }
            set
            {
                if ( value != idealeVochtigheid )
                {
                    idealeVochtigheid = value;
                    OnPropertyChanged( "IdealeVochtigheid" );
                }
            }
        }
        #endregion

        #region Constructor


        public Serre( string serre_id, double grootte, double hoogte, double idealetemp, int idealevochtigheid )
        {
            Serre_ID = serre_id;
            Grootte = grootte;
            Hoogte = hoogte;
            IdealeTemp = idealetemp;
            IdealeVochtigheid = idealevochtigheid;

            lijstSerres.Add( this );
        }

        #endregion
    }
}
