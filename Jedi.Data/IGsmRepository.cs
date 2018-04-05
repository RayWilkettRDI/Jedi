using System.Collections.Generic;
using Jedi.Models.Entities.PDM;
using Jedi.Models.Entities.PDM.Gsm.Common;
using Jedi.Models.Entities.PDM.Gsm.Specifications;


namespace Jedi.Data
{
    public interface IGsmRepository
    {
        IEnumerable<string> GetSearchAttributes();
        SpecSummary GetSpec(string specNum, string issueNum);
        IEnumerable<SpecSummary> GetSpecSummariesBySpecName(int specType, string specName);
        IEnumerable<SpecSummary> GetSpecSummariesBySpecType(int specType, string status);
        IEnumerable<CommonWorkflowStatus> GetWorkflowStatuses(int langid);
    }
}