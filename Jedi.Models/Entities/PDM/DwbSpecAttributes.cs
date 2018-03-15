using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbSpecAttributes")]
    public partial class DwbSpecAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkVolumeUOM", TypeName = "char(40)")]
        public string FkVolumeUom { get; set; }
        public double? LowerControl { get; set; }
        [Column("fkMassUOM", TypeName = "char(40)")]
        public string FkMassUom { get; set; }
        public double? TotalSolids { get; set; }
        public double? UpperLimit { get; set; }
        public double? UpperControl { get; set; }
        [StringLength(4000)]
        public string CombinedIngredientStatement { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public double? LowerLimit { get; set; }
        public double? MassValue { get; set; }
        public double? VolumeValue { get; set; }
        public double? AdjCostCost { get; set; }
        [Column("fkAdjCostCurrency", TypeName = "char(40)")]
        public string FkAdjCostCurrency { get; set; }
        public double? AdjCostAmount { get; set; }
        [Column("fkAdjCostUOM", TypeName = "char(40)")]
        public string FkAdjCostUom { get; set; }
        [Column("fkExperimentParent")]
        [StringLength(40)]
        public string FkExperimentParent { get; set; }
        [Column("fkBasisParent")]
        [StringLength(40)]
        public string FkBasisParent { get; set; }
        public double? EdiblePortion { get; set; }
    }
}
