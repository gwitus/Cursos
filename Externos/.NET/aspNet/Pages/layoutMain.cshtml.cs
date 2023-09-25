using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspNet.Pages
{
    public class layoutMain : PageModel
    {
        private readonly ILogger<layoutMain> _logger;

        public layoutMain(ILogger<layoutMain> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}