using System.Collections.Generic;
using Jedi.Models.Entities.PDM;

namespace Jedi.Data
{
    public interface IGsmRepository
    {
        IEnumerable<SpecSummary> GetSpecSummariesBySpecName(int specType, string specName);
    }
}