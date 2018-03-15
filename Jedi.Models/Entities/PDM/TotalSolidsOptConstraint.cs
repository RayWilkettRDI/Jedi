using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TotalSolidsOptConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? TargetTotalSolids { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
        public int? Sequence { get; set; }
        [StringLength(3)]
        public string Operator { get; set; }
    }
}
