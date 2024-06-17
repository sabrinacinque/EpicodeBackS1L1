using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Veicolo
    {

        string marca;
        string modello;
        int immatricolazione;

        public Veicolo(string marca, string modello,int immatricolazione)
        {
            this.marca = marca;
            this.modello = modello;
            this.immatricolazione = immatricolazione;
                
        }

        public string Marca
        {

        get { return marca; } 
        set {  marca = value; }
        }

        public string Modello
        {
            get { return modello; }
            set { modello = value; }

        }

        public int Immatricolazione
        {
            get { return immatricolazione; }
            set { immatricolazione = value; }
        }

        public string infoVeicolo()
        {
            return "marca : " + marca + " , modello : " + modello + ",anno di immatricolazione : " + immatricolazione;
        }


    }
}
