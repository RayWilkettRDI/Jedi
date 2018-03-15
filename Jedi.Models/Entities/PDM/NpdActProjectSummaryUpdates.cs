using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActProjectSummaryUpdates")]
    public partial class NpdActProjectSummaryUpdates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(1536)]
        public string ProjectScope { get; set; }
        [StringLength(1536)]
        public string ProjectRisk { get; set; }
        [Column("fkActivity", TypeName = "char(40)")]
        public string FkActivity { get; set; }
    }
}
