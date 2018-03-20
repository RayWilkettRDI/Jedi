using Jedi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.Service.Controllers
{
    [Route("api/[controller]")]
    public class GsmController : Controller
    {
        private readonly IGsmRepository _repo;
        private readonly ILogger<GsmController> _logger;

        public GsmController(IGsmRepository repo, ILogger<GsmController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get([FromQuery]int specType, [FromQuery]string specName)
        {
            return Ok(_repo.GetSpecSummariesBySpecName(specType, specName));
        }

        [HttpGet("specType/{specType}/{status}")]
        public IActionResult GetBySpecType(int specType, string status)
        {
            return Ok(_repo.GetSpecSummariesBySpecType(specType, status));
        }

        [HttpGet("specNum/{specNum}/issueNum/{issueNum}")]
        public IActionResult Get(string specNum, string issueNum)
        {
            return Ok(_repo.GetSpec(specNum, issueNum));
        }

       
    }
}
