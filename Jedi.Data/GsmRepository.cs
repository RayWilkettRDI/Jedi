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
using Jedi.Models.Entities.PDM.Gsm.Specifications;
using Jedi.Models.Entities.PDM.Gsm.Common;

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
                    .Include(s => s.ShortName)
                    .Include(s => s.CommonWorkflowStatus)
                    .Include(s => s.Taxonomy.CommonSmiltaxonomyNodeMl)
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

        public IEnumerable<SpecSummary> GetSpecSummariesBySpecType(int specType, string status)
        {
            try
            {
                return _ctx.SpecSummary
                    .Include(s => s.SpecSummaryName)
                    .Include(s => s.ShortName)
                    .Include(s => s.CommonWorkflowStatus)
                    .Include(s => s.Taxonomy.CommonSmiltaxonomyNodeMl)
                    .Where(s => s.SpecType == specType && s.CommonWorkflowStatus.Status == status)
                    .OrderBy(s => s.SpecNum)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get SpecSummary by specType and specName {ex}");
                return null;
            }
        }

        public SpecSummary GetSpec(string specNum, string issueNum)
        {
            try
            {
                return _ctx.SpecSummary
                    .Where(s => s.SpecNum == specNum)
                    .Include(s => s.SpecSummaryName)
                    .Include(s => s.ShortName)
                    .Include(s => s.CommonWorkflowStatus)
                    .Include(s => s.Taxonomy.CommonSmiltaxonomyNodeMl)
                    .FirstOrDefault();
            }
            catch(Exception ex)
            {
                _logger.LogError($"Failed to get SpecSummary by specNum and IssueNum {ex}");
                return null;
            }
        }

        public IEnumerable<string> GetSearchAttributes()
        {
            return new List<string>
            {
                "Category",
                "SubCategory",
                "Group"
            };
        }

        public IEnumerable<CommonWorkflowStatus> GetWorkflowStatuses(int langid)
        {
            try
            {
                return _ctx.CommonWorkflowStatus
                    .Where(s => s.LangId == langid)
                    .ToList();
            }
            catch(Exception ex)
            {
                _logger.LogError($"Failed to get Workflow Statuses {ex}");
                return null;
            }
        }
    }
}
