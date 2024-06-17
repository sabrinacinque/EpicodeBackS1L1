using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendente
    {

        string nome;
        string cognome;
        string mansione;

        public Dipendente(string nome, string cognome, string mansione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.mansione = mansione;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public string Mansione
        {
            get { return mansione; }
            set { mansione = value; }
        }


        public string infoDipendente()
        {
            return "nome:" + this.nome + ",cognome:" + this.cognome + ",mansione : " + mansione;
        }

    }
}
