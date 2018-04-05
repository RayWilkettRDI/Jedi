using Jedi.Models.Entities.PDM;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Jedi.Models.Entities.PDM.Global;

namespace Jedi.Data
{
    public class AdminRepository : IAdminRepository
    {
        private readonly PdmContext _ctx;
        private readonly ILogger<AdminRepository> _logger;

        public AdminRepository(PdmContext ctx, ILogger<AdminRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<SupportedLanguages> GetSupportedLanguages()
        {
            try
            {
                return _ctx.SupportedLanguages
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Supported Languages {ex}");
                return null;
            }
        }
    }
}
