﻿using Jedi.Models.Entities.PDM;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.Data
{
    public class GsmRepository
    {
        private readonly PdmContext _ctx;
        private readonly ILogger<GsmRepository> _logger;

        public GsmRepository(PdmContext ctx, ILogger<GsmRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<SpecSummary> GetSpecSummaries(int specType)
        {
            try
            {
                return _ctx.SpecSummary
                    .Where(s => s.SpecType == specType)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Trade Spec by SpecId {ex}");
                return null;
            }
        }
    }
}