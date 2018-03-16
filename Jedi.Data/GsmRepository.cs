using Jedi.Models.Entities.PDM;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.Data
{
    public class GsmRepository : IGsmRepository
    {
        private readonly PdmContext _ctx;
        private readonly ILogger<GsmRepository> _logger;

        public GsmRepository(PdmContext ctx, ILogger<GsmRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<SpecSummary> GetSpecSummariesBySpecName(int specType, string specName)
        {
            try
            {
                return _ctx.SpecSummary
                    .Include(s => s.SpecSummaryName)
                    .Include(s => s.CommonWorkflowStatus)
                    .Where(s => s.SpecType == specType && s.SpecSummaryName.Name.Contains(specName))
                    .OrderBy(s => s.SpecNum)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get SpecSummary by specType and specName {ex}");
                return null;
            }
        }
    }
}
