using Jedi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jedi.Controllers
{
    public class GsmController : Controller
    {
        private readonly IJediRepository _repository;
        private readonly ILogger _logger;

        public GsmController(IJediRepository repository, ILogger logger)
        {
            this._repository = repository;
            this._logger = logger;
        }
    }
}
