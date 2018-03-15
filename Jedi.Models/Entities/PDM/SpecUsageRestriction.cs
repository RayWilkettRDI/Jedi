using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specUsageRestriction")]
    public partial class SpecUsageRestriction
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Required]
        [StringLength(50)]
        public string AffiliateName { get; set; }
        [Column("fkSpecBusinessUnit", TypeName = "char(40)")]
        public string FkSpecBusinessUnit { get; set; }
    }
}
