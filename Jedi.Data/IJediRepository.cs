using System.Collections.Generic;
using Jedi.Models.Entities.Specs;

namespace Jedi.Data
{
    public interface IJediRepository
    {
        IEnumerable<TradeSpec> GetAllTradeSpecs();
        TradeSpec GetTradeSpecBySpecID(string specId);
    }
}