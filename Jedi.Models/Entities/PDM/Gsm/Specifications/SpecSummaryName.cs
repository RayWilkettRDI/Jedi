using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    public partial class SpecSummaryName
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpecsummary", TypeName = "char(40)")]
        public string FkSpecsummary { get; set; }
        [Column("langid")]
        public int Langid { get; set; }
        [Column("name")]
        [StringLength(256)]
        public string Name { get; set; }

        [ForeignKey("fkSpecSummary")]
        public SpecSummary specSummary { get; set; }
    }
}
