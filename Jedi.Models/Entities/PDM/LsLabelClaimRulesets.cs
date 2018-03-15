using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("lsLabelClaimRulesets")]
    public partial class LsLabelClaimRulesets
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Sequence { get; set; }
        [Column("fkLabelClaim", TypeName = "char(40)")]
        public string FkLabelClaim { get; set; }
    }
}
