using System;
using Pessoa;

namespace PrincipalManager {
    class Program{
        static void Main (){
            // Forma de se fazer caso os atributos estivessem em public
            // Candidato candidato = new Candidato {
            //     nome      = "gwitus",
            //     idade     = 23,
            //     formation = "Análise e desenvolvimento de Sistemas",
            // };

            Candidato candidato = new();
            // Fazendo o básico de POO
            
            // Maneira Java de fazer (Só com o nome diferente)
            candidato.NomearCandidato("gwitus");
            candidato.MostrarNome();

            // Maneira do curso de realizar a parada
            candidato.Nome = "Elon Musk";
            Console.WriteLine($"Nome: {candidato.Nome});
        }
    }
}