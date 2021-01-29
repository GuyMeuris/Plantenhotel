using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantenhotel
{
    class Recensies : ObservableObject
    {

        #region velden op klasse niveau
       
        public static List<Recensies> lijstRecensies = new List<Recensies>();

        //static = 1 instantie naar alles instanties (niet 1 maar meerdere recensies)

        #endregion

        #region Velden op instantie niveau //zijn gekoppeld aan 1 instantie van de klasse
        /// <summary>
        /// Datum wanneer klant heeft geregistreerd op registratiepagina
        /// klantSinds = DateTime.Now() bij registratie
        /// </summary>
        private string klant;

        /// <summary>
        /// Aantal bestelling dat klant sinds begin al heeft geplaatst
        /// Beginwaarde is 0
        /// </summary>
        private string recensie;


        //

        #endregion

        #region Properties

        public string Klant
        {
            get { return klant; }
            set
            {
                if (value != klant)
                {
                    klant = value;
                    OnPropertyChanged("Klant");
                }
            }
        }

        public string Recensie
        {
            get { return recensie; }
            set
            {
                if (value != recensie)
                {
                    recensie = value;
                    OnPropertyChanged("Recensie");
                }
            }
        }


        #endregion

        #region constructor

        public Recensies(string klant1, string rec1)
        {
            Klant = klant1;
            Recensie = rec1;

            lijstRecensies.Add(this); //this = volledig instantieobject
        }

        #endregion


    }
}

