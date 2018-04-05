using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jedi.Models.Entities.PDM;
using Jedi.Models.Entities.PDM.Gsm.Specifications;

namespace Jedi.Web.WebServiceAccess.Base
{
    public interface IWebApiCalls
    {
        Task<IList<SpecSummary>> GetSpecsAsync();
    }
}
