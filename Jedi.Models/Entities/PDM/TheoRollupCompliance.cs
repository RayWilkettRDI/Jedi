using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TheoRollupCompliance
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(1024)]
        public string Comments { get; set; }
        [Required]
        [Column("fkCompliance", TypeName = "char(40)")]
        public string FkCompliance { get; set; }
        [Required]
        [Column("fkComplianceOverride", TypeName = "char(40)")]
        public string FkComplianceOverride { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public bool IsOverrideOnly { get; set; }
    }
}
