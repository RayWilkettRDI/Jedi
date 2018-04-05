using System.Collections.Generic;
using Jedi.Models.Entities.PDM.Global;

namespace Jedi.Data
{
    public interface IAdminRepository
    {
        IEnumerable<SupportedLanguages> GetSupportedLanguages();
    }
}