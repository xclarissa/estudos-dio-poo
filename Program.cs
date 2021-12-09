using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();

            p1.Nota = 7.5;
            
            Professor p2 = new Professor();
            p2.Salario = 7500;

            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30); //só é possível alterar o método q é public
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // static void Main(string[] args)
            // {
            //     Pessoa p1 = new Pessoa();

            //     p1.Nome = "Clarissa";
            //     p1.Idade = 27;

            //     p1.Apresentar();
            // }
        }

    }
}
