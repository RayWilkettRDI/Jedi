using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class OptimizationBomItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? UpperControl { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
        public double? UpperLimit { get; set; }
        public double? LowerControl { get; set; }
        public double? LowerLimit { get; set; }
        [Column(TypeName = "char(1)")]
        public string Hint { get; set; }
        public double? FinalYieldQuantity { get; set; }
        [Column("fkUom", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column(TypeName = "char(40)")]
        public string FormulationInputPkid { get; set; }
    }
}
