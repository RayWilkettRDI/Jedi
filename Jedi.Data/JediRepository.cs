using Jedi.Models.Entities.Specs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.Data
{
    public class JediRepository : IJediRepository
    {
        private readonly JediContext _ctx;
        private readonly ILogger<JediRepository> _logger;

        public JediRepository(JediContext ctx, ILogger<JediRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<TradeSpec> GetAllTradeSpecs()
        {
            try
            {
                return _ctx.TradeSpecs.ToList();
            }
            catch(Exception ex)
            {
                _logger.LogError($"Failed to get all Trade Specs {ex}");
                return null;
            }
        }

        public TradeSpec GetTradeSpecBySpecID(string specId)
        {
            try
            {
                return _ctx.TradeSpecs
                    .Where(t => t.SpecID == specId)
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Trade Spec by SpecId {ex}");
                return null;
            }
        }
    }
}
