// anotações simples sobre C# para começau
using System;
using Animal;

namespace EmanuelTeste {
    class Program {
        static void Main () {
            Console.WriteLine("Hello world!");
            Mamifero animalMamifero = new Mamifero();
            // Desta forma dá errado, por conta da declaração do atributo ser private
            // animalMamifero.especie = "gwitus";
            // Agora de uma forma de public 
            animalMamifero.minhaEspecie = "Human";
            animalMamifero.minhaEspecie = "teste2002";
            string aux = animalMamifero.minhaEspecie;
            Console.WriteLine(aux);
            // agora de uma forma protected
        }    
    }
}