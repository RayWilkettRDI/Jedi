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
    public class TradeSpecController : Controller
    {
        private readonly IJediRepository _repo;
        private readonly ILogger<TradeSpecController> _logger;

        public TradeSpecController(IJediRepository repo, ILogger<TradeSpecController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllTradeSpecs());
        }

        [HttpGet("id")]
        public IActionResult Get(string id)
        {
            var item = _repo.GetTradeSpecBySpecID(id);
            if(item == null)
            {
                return NotFound();
            }

            return Json(item);
        }
    }
}
