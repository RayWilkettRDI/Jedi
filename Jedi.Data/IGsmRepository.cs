﻿using System.Collections.Generic;
using Jedi.Models.Entities.PDM;

namespace Jedi.Data
{
    public interface IGsmRepository
    {
        IEnumerable<string> GetSearchAttributes();
        SpecSummary GetSpec(string specNum, string issueNum);
        IEnumerable<SpecSummary> GetSpecSummariesBySpecName(int specType, string specName);
        IEnumerable<SpecSummary> GetSpecSummariesBySpecType(int specType, string status);
    }
}