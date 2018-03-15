using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SpecToSpecRatioOptConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFormulationInput2", TypeName = "char(40)")]
        public string FkFormulationInput2 { get; set; }
        [Column("fkFormulationInput1", TypeName = "char(40)")]
        public string FkFormulationInput1 { get; set; }
        [StringLength(3)]
        public string Operator { get; set; }
        public int? Sequence { get; set; }
        public double? Spec2Ratio { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
        public double? Spec1Ratio { get; set; }
    }
}
