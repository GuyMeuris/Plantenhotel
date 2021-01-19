using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Plantenhotel
{
    /// <summary>
    /// Is een custom klasse die het veelvuldig gebruik van 
    /// de 'property change notification' vermijdt.
    /// </summary>
    // Met dank aan 'Rachel Lim's Blog' : 
    // https://rachel53461.wordpress.com/2011/05/08/simplemvvmexample/

    public class ObservableObject : INotifyPropertyChanged   // Implementatie van een hulpvolle interface
    {
        #region INotifyPropertyChanged Members

        /// <summary>
        /// Deze eventhandler-variabele gaat aangeven wanneer er iets is gewijzigd.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Methode om de 'PropertyChangedEventHandler' de wijziging te laten aangeven.
        /// </summary>
        /// <param name="naamProperty">De nieuwe waarde van de property.</param>
        protected virtual void OnPropertyChanged( string naamProperty )
        {
            this.VerifyPropertyName( naamProperty );

            if ( this.PropertyChanged != null )
            {
                PropertyChangedEventArgs wijziging = new PropertyChangedEventArgs( naamProperty );
                this.PropertyChanged( this, wijziging );
            }
        }

        #endregion

        #region Debugging Hulpmiddel
        /// <summary>
        /// Geeft aan wanneer een 'Exception is thrown' (zie code onder) of wanneer de
        /// Debug.Fail() methode wordt aangeroepen bij het meegeven van een foutieve
        /// property-naam aan de 'VerifyPropertyName'-methode. Default-waarde is 'false',
        /// maar subklassen - gebruikt door 'unit tests' - zouden de getter van deze 
        /// property wel eens kunnen 'overriden' naar 'true'.
        /// </summary>
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }

        /// <summary>
        /// Waarschuwt de developer als deze instantie niet
        /// de juiste (public) property heeft met de bijhorende naam.
        /// Deze methode wordt NIET meegenomen in de 'release build'
        /// en dient uitsluitend als hulpmiddel tijdens het 'debuggen'.
        /// </summary>
        [Conditional( "DEBUG" )]
        [DebuggerStepThrough]
        public virtual void VerifyPropertyName( string naamProperty )
        {
            // Bevestigd dat de meegegeven waarde van deze property
            // zeker overeenstemt met de waarde van de (public) instantie-
            // property van dit klasse-object.
            if ( TypeDescriptor.GetProperties( this )[naamProperty] == null )
            {
                string boodschap = $"De meegegeven property-naam '{naamProperty}' is niet juist!";

                if ( this.ThrowOnInvalidPropertyName )
                {
                    throw new Exception( boodschap );
                }
                else
                {
                    Debug.Fail( boodschap );
                }
            }
        }
        #endregion
    }

}
