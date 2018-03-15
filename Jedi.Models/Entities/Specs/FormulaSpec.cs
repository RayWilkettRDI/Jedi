using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jedi.Models.Entities.Specs
{
    public class FormulaSpec : BaseSpec
    {
        public IEnumerable<FormulationInput> Inputs { get; set; }
    }
}
