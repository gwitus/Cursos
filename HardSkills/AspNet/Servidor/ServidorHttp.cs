using System.Net;
using System.Net.Sockets;
using System;
using System.Threading.Tasks;

class ServidorHttp {
    private object servirdorHttpTask;

    //tem um objeo do tipo TcpListener, seu objetivo é ficar escutando uma porta de rede 
    //do computador aguardando uma conexão do tipo tcp
    private TcpListener Controlador { get; set; }
    //porta usada 8080
    private int Porta { get; set; } 
    //Contador para verificar se alguma conexão foi perdida durante o processo, por isso do tipo int
    private int QuantidadeRequests { get; set;}

    //Chamando o construtor passando o atributo porta, e utilizando o método setter para atribuir 
    //O valor da variavel porta ao atributo porta propriamente dito
    public ServidorHttp (int porta = 8080)
    {
        //método setter
        this.Porta = porta;

        try
        {
            //Objeto do tipo tcp listener que vai escutar no localhost na porta 8080
            this.Controlador = new TcpListener(IPAddress.Parse("127.0.0.1"), this.Porta);
            //Inicia Escuta
            this.Controlador.Start();
            //Imprimir mensagens no debugador do Console[
            Console.WriteLine($"ServidorHttp está rodando na porta {this.Porta}.");            
            Console.WriteLine($"Para acessar, digite no navegador: http://localhost:{this.Porta}.");        
            Task servidorHttpTask = Task.Run(() => AguardarRequersts());
            servidorHttpTask.GetAwaiter().GetResult();

        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao iniciar servidor na porta: {this.Porta}:\n{e.Message}");
        }
    }

    //Modificador Async para poder ser executado de forma assincrona
    private async Task AguardarRequersts (){
        //Looping infinito aguardando requisição
        while (true)
        {
            //A cada interação, o método do loop, o método AcceptSocketAsync fica aguardando requisição e quando detecta retorna um objeto do tipo socket;
            Socket conexao = await this.Controlador.AcceptSocketAsync();
            //Assim que aceita, o contador faz o trabalho para identificarmos quantos foram;
            this.QuantidadeRequests++;

            //chamada de método
            //chamada de forma que o processamento de cada requisição seja feita de forma independente
            //Tipo Task + / - igual a lógica de threads
            Task task = Task.Run(() => ProcessarRequest(conexao, this.QuantidadeRequests));
        }
    }

    //Processando Requisições
    private void ProcessarRequest (Socket conexao, int numeroRequest) 
    {
        Console.WriteLine($"Processando Request #{numeroRequest}...\n");
        if (conexao.Connected)
        {
            Byte[] bytesRequisicao = new byte[1024];
            //conexão vai preencher com receive a cadeia de bytes declarada acima
            //Com dados recebidos. 1 - Onde guardar, 2 - Quantos eu quero ler, 3 - Que posição;
            conexao.Receive(bytesRequisicao, bytesRequisicao.Length, 0);
            //Pega a expressão acima e converte para o padrão UTF8, e então substitui 0 por espaço, e então o TRIM retira todos os espaços
            //Esse passo se faz necessário pq nem sempre a cadeia de bytes com 1024 posições será preenchida;
            string textoRequisicao = System.Text.Encoding.UTF8.GetString(bytesRequisicao).Replace((char)0, ' ').Trim();
            
            //Após limpeza da memória, precisamos reconhecer se a requisição é maior do que 0
            if(textoRequisicao.Length > 0) 
            {
                Console.WriteLine($"Requisicao: {textoRequisicao}");
                conexao.Close();
            }
        }
        Console.WriteLine($"\nRequest {numeroRequest} finalizado.");
    }



}