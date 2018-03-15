using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.Models.Entities.Specs
{
    public interface IBaseSpec
    {
        string SpecID { get; set; }
        string SpecNum { get; set; }
        string IssueNum { get; set; }
        string ShortName { get; set; }
        string Name { get; set; }
        string Status { get; set; }
        string Category { get; set; }
        string SubCategory { get; set; }
        string Group { get; set; }
        string ReasonForChange { get; set; }
        IEnumerable<CrossReference> CrossReferences { get; set; }
    }
}
