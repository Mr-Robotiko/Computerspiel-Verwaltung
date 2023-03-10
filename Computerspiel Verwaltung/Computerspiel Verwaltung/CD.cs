using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computerspiel_Verwaltung
{
    class CD : Computerspiele
    {
        private string verfahren;
        private string hersteller;
        private string gebraucht;
        private bool garantie;

        public string Verfahren { get => verfahren; set => verfahren = value; }
        public string Hersteller { get => hersteller; set => hersteller = value; }
        public string Gebraucht { get => gebraucht; set => gebraucht = value; }
        public bool Garantie { get => garantie; set => garantie = value; }
    }
}
