using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {

        string nome;
        string cognome;
        int eta;
        string categoria;


        public Atleta(string nome, string cognome, int eta, string categoria)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.categoria = categoria;
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

        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }


        public string infoAtleta()
        {
            return "nome:" + this.nome + ",cognome:" + this.cognome + ",eta:" + this.eta + ",categoria : " + this.categoria;
        }



    }
}
