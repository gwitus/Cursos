using System;

namespace calculadora {
    class calculadorafoda{
        static void Main(string[] args){
            Console.WriteLine("\n\nSalve lek, isso aqui é uma calculadora\n");
            double resultado;
            var numero1 = 0.0;
            var numero2 = 0.0;
            int escolha = 0;
            int contador = 0;
            string tmp;

            while (contador == 0){
                Console.WriteLine("\nInsira 2 números em ordem consecultiva para realizar uma operação");
                tmp = Console.ReadLine();
                numero1 = double.Parse(tmp);

                tmp = Console.ReadLine();
                numero2 = double.Parse(tmp);

                Console.WriteLine("Escolha uma operação a ser realizada;\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Desligar sistema\n");
                tmp = Console.ReadLine();
                escolha = int.Parse(tmp);

                switch (escolha){
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("\nA soma das váriaveis resulta em: " + resultado);
                        Console.WriteLine("\n\n");
                        break;
                    
                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("\nA subtração das váriaveis resulta em: " + resultado);
                        Console.WriteLine("\n\n");
                        break;
                    
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("\nA multiplicação das váriaveis resulta em: " + resultado);
                        Console.WriteLine("\n\n");
                        break;
                    
                    case 4:
                        resultado = numero1 / numero2;
                        Console.WriteLine("\nA divisão das váriaveis resulta em: " + resultado);
                        Console.WriteLine("\n\n");
                        break;
                    
                    default:
                        Console.WriteLine("Sistema encerrado!\n");
                        contador ++;
                        break;
                }
            }
        }
    }
    
}