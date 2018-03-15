using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.Specs
{
    [Table(name: "Trade_Specifications", Schema = "pdm")]
    public class TradeSpec : IBaseSpec
    {
        // Summary Information Properties
        [Column("SpecID")]
        public string SpecID { get; set; }
        [Column("SpecNum")]
        public string SpecNum { get; set; }
        [Column("IssueNum")]
        public string IssueNum { get; set; }
        [Column("ShortName")]
        public string ShortName { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("Category")]
        public string Category { get; set; }
        [Column("SubCategory")]
        public string SubCategory { get; set; }
        [Column("Group")]
        public string Group { get; set; }
        [Column("ReasonForChange")]
        public string ReasonForChange { get; set; }
        public IEnumerable<CrossReference> CrossReferences { get; set; }
        [Column("ProductCode")]
        public string Gtin { get; set; }
        //public string Description { get; set; }
        //public MaterialSpec MaterialSpec { get; set; }
        [Column("TradeType")]
        public string TradeItemType { get; set; }
        //public string PluDescription { get; set; }
        //public string POSDescription { get; set; }
        //public string UdexClassification { get; set; }
        [Column("GPCCode")]
        public string GpcCode { get; set; }
        //public IEnumerable<string> CountryOfOrigin { get; set; }
        //public IEnumerable<PackagingSpec> PackagingSpecs { get; set; }

    }
}
