using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jedi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Jedi.Service.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly IAdminRepository _repo;
        private readonly ILogger<AdminController> _logger;
        public AdminController(IAdminRepository repo, ILogger<AdminController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet("supportedlanguages")]
        public IActionResult GetSupportedLanguages()
        {
            return Ok(_repo.GetSupportedLanguages());
        }
    }
}
