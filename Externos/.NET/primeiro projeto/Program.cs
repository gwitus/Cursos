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
            Console.WriteLine($"Nome: {candidato.Nome}");

            // Chamando funções
            Program.TesteFunction();
            
            // Funções com parametros
            int aux = SomarNumero(1,3);
            Console.WriteLine(aux); 

            // Chamando de outra forma
            Console.WriteLine(SomarNumero(1,2));

            //++++++++++Foreach para percorrer+++++++++++++\\
            numeros.Add(10);
            numeros.Add(20);

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }
            
        }

        // Aprendendo funções
        // Estava dando o erro devido ao static não estar configurado
        // Estrutura de uma função : modificador_retorno TipoDeRetorno NomeDaFuncao(parâmetros){}
        private static string TesteFunction () {
            return "Deu certo!";
        }

        // Funções com parametros
        public static int SomarNumero(int a, int b){
            return a + b;
        }

        private static List<int> numeros = new List<int>();
    }
}