using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computerspiel_Verwaltung
{
    class Online : Computerspiele
    {
        private string anbierter;
        private string plattform;
        private bool abbo;

        public string Anbierter { get => anbierter; set => anbierter = value; }
        public string Plattform { get => plattform; set => plattform = value; }
        public bool Abbo { get => abbo; set => abbo = value; }
    }
}
