using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Card {
    class anotações {
        // Vou deixando isso aqui para ir anotando e executando as aplicações
        
        // Por padrão o modificador é o public
        static void Main (){
        
        // Fundamentos do C#
        int inteiro = 32;
        float real = 32.3f;
        // Por teoria dos conjuntos
        real = inteiro;
        //Se eu quiser de alguma forma um conversão direta dessas de forma ao contrário
        inteiro = (int)real;

        // Convert
        string aux = Convert.ToString(real); 
        // Parse
        string aux2 = real.ToString();


        Console.WriteLine(inteiro + real);

        var x = "HttpStyleUriParser";
        const float pi = 3.14f; 


        // Algumas condicionais 
        // Condicional comum
        if (1 == 1) {
            Console.WriteLine("teste");
        }

        // Condicional a lá pyton
        // Obs, quem faz assim para mim a não ser para deixar mais clean merece levar paulada
        // lá ele

        // Lembrando que esse método escroto só funciona quando se a condicional for verdadeira o comando seja de apenas uma linha

        if (1==1)
            Console.WriteLine("Deu certo sem as chaves");

        // Em C# a respeito do While, o do While se mantém, ele serve para garantir que a função do while será executada pelo menos uma vez
        // De acordo o Curso do Balta, não é tão utilizado essa estrutura em C#


        // Métodos de declaração

        string aux3 = "Teste";
        string aux4 = "teste2";

            // Forma javascript de se fazer
            // isso aqui conta mais como se fosse uma função
            static string aux5 (
            string nome,
            string idade,
            string teste
            // OBS: o ultimo parametro não deve ter virgula
            // OBS2: Parametros opcionais ou que podem ser nulos devem vir por ultimo, não por convenção mas por compilação
        ){
            return nome;
        }

        // Agora para chamar essa trambolho acima, se faz assim
        string aux6 = aux5("gwitus", "144", "teste");
        // Aqui vai printar o que o return lá em cima descreveu, mas vai salvar os parametros atribuidos
        Console.Write(aux6);
        }        


        // Sobre structs
        // Método construtor (Método com o nome da struct)
        struct Program
        {
            public Program(int id, string title, float price) {
                // ID = id;
                // Title = title;
            }
        }
        
        // Como observado, C# tem strutch
        // instancia da struct
        // var teste = new Program();
    
        // Enumeradores
        // Pode ser utilizado como tipo
        // Escrito como inteiro
        enum EEstadoCivil
        {
            //Lembrando que o parametro tem que ser sempre com a letra maiscula
            solteiro = 1,
            casado = 2,
            Divorciado = 3
        }

        // var cliente = new Program((int)cliente.EEstadoCivil);

        struct Program
        {
            public EProdutoType produto;    
        }

        

        enum EProdutoType{
            Product = 1,
            Service = 2
        }

        // Declaração de array
        var array = new int[1];
        array[1] = 2;

        var teste = "teste";
    }
}