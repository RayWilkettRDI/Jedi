using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.Models.Entities.Specs
{
    public class PackagingSpec : BaseSpec
    {
        public IEnumerable<SourcingApproval> Suppliers { get; set; }
    }
}
