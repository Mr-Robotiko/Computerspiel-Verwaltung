using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computerspiel_Verwaltung
{
    class Computerspiele
    {
        // Aufstellen der notwendigen Attribute
        private string name;
        private string genre;
        private int erscheinungsjahr;
        private int freigabestufe;
        private string entwickler;
        private int preis;

        public Computerspiele()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Erscheinungsjahr { get => erscheinungsjahr; set => erscheinungsjahr = value; }
        public int Freigabestufe { get => freigabestufe; set => freigabestufe = value; }
        public string Entwickler { get => entwickler; set => entwickler = value; }
        public int Preis { get => preis; set => preis = value; }

        /// <summary>
        /// Definieren der Fehler Indikatoren. -> Erscheinungsjahr.
        /// </summary>
        /// <returns></returns>
        public bool Jahr()
        {
            int jahr = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            if (Erscheinungsjahr <= 1978 || Erscheinungsjahr > jahr)
            {
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Definieren der Fehler Indikatoren. -> Alter laut der USK. 
        /// </summary>
        /// <returns></returns>
        public bool Alter()
        {
            switch (freigabestufe)
            {
                case 0:
                    return true;
                    break;

                case 6:
                    return true;
                    break;

                case 12:
                    return true;
                    break;

                case 16:
                    return true;
                    break;

                case 18:
                    return true;
                    break;

                default: return false;
            }

        }

    }
}
