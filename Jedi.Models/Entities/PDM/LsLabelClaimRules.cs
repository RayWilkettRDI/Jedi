using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("lsLabelClaimRules")]
    public partial class LsLabelClaimRules
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(1250)]
        public string Formula { get; set; }
        public int? Sequence { get; set; }
        [StringLength(2500)]
        public string Comments { get; set; }
        [Column("fkRuleset", TypeName = "char(40)")]
        public string FkRuleset { get; set; }
        [StringLength(1250)]
        public string Calculation { get; set; }
    }
}
