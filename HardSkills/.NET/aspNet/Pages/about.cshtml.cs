using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspNet.Pages
{
    public class about : PageModel
    {
        private readonly ILogger<about> _logger;

        public about(ILogger<about> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}