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
        public void OnGet()
        {
        }

        // Mesma lógica do de cima, mas serve para envio 'POST'
        public void OnPost(){

        }
    }
}