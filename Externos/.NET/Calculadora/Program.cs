// A ideia aqui é começar a praticar e começar pelo simples, uma calculadora de terminal

using System;
using System.Linq.Expressions;

namespace Calculadora {
    class App {
        static void Main (){
            Console.Write("Insira um número para a operação: \n1_Soma,  \t2_Subtração,  \t3_Divisão \t4_Multiplicação\n");
            Console.Write("Operação: ");
            String option = Console.ReadLine();
            int escolha = int.Parse(option);
            Console.Write("Insira o primeiro termo: ");
            String aux =  Console.ReadLine();

            // Tryparse para tentar fazer a conversão
            // aux é o nome da variavel onde a string foi passada
            // numero é uma var de ambiente
            // out int é um parametro de saída

            int a = int.Parse(aux);
            Console.Write("Insira o segundo termo: ");
            String aux2 = Console.ReadLine();
            int b = int.Parse(aux2);

            if (escolha <= 4 || escolha >= 1){
                switch (escolha){
                    case 1:
                        // Se colocar só +, vai concatenando e fica esquisito que nem no JavaScript
                        Console.WriteLine("Resultado: " + (a + b)); 
                        break;
                    case 2:
                        Console.WriteLine("Resultado: " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Resultado: " + (a / b));
                        break;    
                    default:
                        Console.WriteLine("Resultado: " + (a * b));
                        break;
            }
            } else {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}