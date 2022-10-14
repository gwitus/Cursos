using System.Net.Sockets;

class ServidorHttp {
    //tem um objeo do tipo TcpListener, seu objetivo é ficar escutando uma porta de rede 
    //do computador aguardando uma conexão do tipo tcp
    private TcpListener Controlador { get; set; }
    //porta usada 8080
    private int Porta { get; set; } 
    //Contador para verificar se alguma conexão foi perdida durante o processo, por isso do tipo int
    private int QuantidadeRequests { get; set;}

    //Chamando o construtor passando o atributo porta, e utilizando o método setter para atribuir 
    //O valor da variavel porta ao atributo porta propriamente dito
    public ServidorHttp (int porta = 8080){
        //método setter
        this.Porta = porta;

        try
        {
            //Objeto do tipo tcp listener que vai escutar no localhost na porta 8080
            this.Controlador = new TcpListener(IPAddress.Parse("127.0.0.1"), this.Porta);
            //Inicia Escuta
            this.Controlador.Start();
            //Imprimir mensagens para o usuári[
            Console.WriteLine($"ServidorHttp está rodando na porta {this.Porta}.");            
            Console.WriteLine($"Para acessar, digite no navegador: http://localhost:{this.Porta}.");            

        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao iniciar servidor na porta: {this.Porta}:\n{e.Message}");
        }
    }
}