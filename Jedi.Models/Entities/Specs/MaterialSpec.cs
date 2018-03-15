using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jedi.Models.Entities.Specs
{
    public class MaterialSpec : BaseSpec
    {
        public string MaterialType { get; set; }
        public string Description { get; set; }
        public string Classification { get; set; }
    }
}
