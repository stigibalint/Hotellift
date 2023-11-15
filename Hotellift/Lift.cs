using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotellift
{
    public class Lift
    {
        string idopont;
        int kartyasorszam, induloszint, celszint;

        public Lift(string idopont, int kartyasorszam, int induloszint, int celszint)
        {
            this.idopont = idopont;
            this.kartyasorszam = kartyasorszam;
            this.induloszint = induloszint;
            this.celszint = celszint;
        }

        public string Idopont { get => idopont;  }
        public int Kartyasorszam { get => kartyasorszam;  }
        public int Induloszint { get => induloszint;  }
        public int Celszint { get => celszint; }


        public Lift(string CSVSOR)
        {
            var mezo = CSVSOR.Split(" ");
            this.idopont = mezo[0];
            this.kartyasorszam = int.Parse(mezo[1]);
            this.induloszint = int.Parse(mezo[2]);
            this.celszint = int.Parse(mezo[3]);
        }
    }

}
