using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Seadmed
    {


        public String Seade { get; set; }
        public double Elekter { get; set; } //ei saa kasutada integer
        public DateTime Aeg { get; set; }
        public bool Lyliti { get; set; }


        public Seadmed(String sd, double ene, DateTime ag, bool lt)
        {
            this.Seade = sd;
            this.Elekter = ene;
            this.Aeg = ag;
            this.Lyliti = lt;

        }

        public Seadmed()
        {

        }
    }
}
