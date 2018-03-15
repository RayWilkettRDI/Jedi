using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jedi.Controllers
{
    public class AppController : Controller
    {
        private readonly ILogger<AppController> _logger;
        private readonly IConfiguration _config;

        public AppController(ILogger<AppController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Gsm")]
        public IActionResult Gsm()
        {
            return View();
        }
    }
}
