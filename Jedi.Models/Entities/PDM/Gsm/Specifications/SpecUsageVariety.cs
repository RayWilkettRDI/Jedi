using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specUsageVariety")]
    public partial class SpecUsageVariety
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkFinishedProduct", TypeName = "char(40)")]
        public string FkFinishedProduct { get; set; }
        [Required]
        [StringLength(128)]
        public string AffiliateName { get; set; }
        [StringLength(50)]
        public string VarietyNumber { get; set; }
        [StringLength(50)]
        public string VarietySymbol { get; set; }
        [Column("fkSpecBusinessUnit", TypeName = "char(40)")]
        public string FkSpecBusinessUnit { get; set; }
    }
}
