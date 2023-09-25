using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

// Arquivo principal para renderização
// Tudo que se trata de aspNet está sendo renderizado e gerado no servidor,
// Não é diferente com o Razor onde o Html final é renderizado no servidor e trazido para o cliente


// Basicamente, o que é colocado aqui de forma bem medíocre é como se fosse o BackEnd
// E o que é colocado no outro arquivo é básicamente a chamada do front

// Possível o reuso de código
namespace aspNet.Pages
{
    public class index : PageModel
    {
        private readonly ILogger<index> _logger;

        public index(ILogger<index> logger)
        {
            _logger = logger;
        }
        // Executado sempre que a página é renderizada, 'GET'
        // Tornei assincrono

        // Esse new da frente é um tipo de inicialização anonima do C#
        // Precisou fazer por que se você tem uma lista que não foi iniciada, não vai ser possível
        // ... salvar os dados desejados
        public List<Category> Categories {get; set;} = new();
        public async Task OnGet()
        {
            // Processado do lado do servidor
            await Task.Delay(200);
            for (int i = 0; i <= 10; i ++){
               Categories.Add(new Category(i, i * 12));
            }
        }

        // Mesma lógica do de cima, mas serve para envio 'POST'
        public void OnPost(){

        }
    }
    
    // Classe sem comportamente devido ao modificador record
    public record Category(int Id, decimal Price);
}