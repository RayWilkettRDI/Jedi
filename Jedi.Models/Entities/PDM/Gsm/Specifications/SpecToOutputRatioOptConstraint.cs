using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    public partial class SpecToOutputRatioOptConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
        public double? SpecRatio { get; set; }
        [Column("fkFormulationInput", TypeName = "char(40)")]
        public string FkFormulationInput { get; set; }
        [StringLength(3)]
        public string Operator { get; set; }
        public int? Sequence { get; set; }
    }
}
