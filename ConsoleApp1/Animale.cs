using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animale
    {
        string razza;
        string colore;
        int eta;

        public Animale(string razza, string colore, int eta)
        {
            this.razza = razza;
            this.colore = colore;
            this.eta = eta;
        }

        public string Razza
        {
            get { return razza; }
            set { razza = value; }
        }

        public string Colore
        {
            get { return colore; }
            set { colore = value; }
        }


        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }


        public string infoAnimale()
        {
            return "razza : " + razza + " , colore : " + colore + ",eta : " + eta;
        }

    }
}
