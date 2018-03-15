using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SpecSummaryReasonForChange
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("reasonforchange")]
        [StringLength(1000)]
        public string Reasonforchange { get; set; }
        [Required]
        [Column("fkSpecSummary", TypeName = "char(40)")]
        public string FkSpecSummary { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
