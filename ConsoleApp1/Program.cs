using System;

namespace ConsoleApp1
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Atleta atleta1 = new Atleta("Luigi","Verdi",20,"Corsa");
            Dipendente dipendente1 = new Dipendente("Mario", "Rossi", "Operaio");
            Animale animale1 = new Animale("cane", "marrone", 5);
            Veicolo veicolo1 = new Veicolo("fiat", "500 abarth", 2015);

            Console.WriteLine(atleta1.Categoria);
            atleta1.Categoria = "Corsa ad ostacoli";
            Console.WriteLine(atleta1.infoAtleta());


            Console.WriteLine(dipendente1.infoDipendente());
            dipendente1.Nome = "Roberto";
            Console.WriteLine("Nuovo nome : " + dipendente1.Nome);

            Console.WriteLine(animale1.infoAnimale());
            animale1.Razza = "gatto";
            Console.WriteLine("nuova razza :" + animale1.Razza);


            Console.WriteLine(veicolo1.infoVeicolo());
            veicolo1.Immatricolazione = 2018;
            Console.WriteLine("nuova immatricolazione :" + veicolo1.Immatricolazione);

        }
    }
}
