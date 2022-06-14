using System;
using Atividade.Entities;

namespace Atividade
{
    class Program {

        static void Main(string[] args)
        {
            
            Guerreiro g = new Guerreiro("Aruz", 20 , "Guerreiro", 2500);
            g.Apresentar();
            g.Attack();

            Magos o = new Magos("Neymar", 500, "Futebolista", 1000);
            o.Apresentar();
            System.Console.WriteLine(o.Attack(100));

            Curador c = new Curador ("Jose", 50, "Curador", 1200);
            c.Apresentar();
            System.Console.WriteLine(c.Attack(500)); 

           

           




        }
    }
}