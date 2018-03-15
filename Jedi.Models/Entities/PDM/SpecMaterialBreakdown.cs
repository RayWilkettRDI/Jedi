using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specMaterialBreakdown")]
    public partial class SpecMaterialBreakdown
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkBreakdown", TypeName = "char(40)")]
        public string FkBreakdown { get; set; }
        [StringLength(2048)]
        public string ComponentDescription { get; set; }
        [StringLength(50)]
        public string Formulation { get; set; }
        [Column("minRange")]
        [StringLength(50)]
        public string MinRange { get; set; }
        [Column("maxRange")]
        [StringLength(50)]
        public string MaxRange { get; set; }
        [Column("fkComponentFunction", TypeName = "char(40)")]
        public string FkComponentFunction { get; set; }
        [Column("persist")]
        public bool? Persist { get; set; }
        public int? Sequence { get; set; }
        [Column("fkIngredientSpec")]
        [StringLength(40)]
        public string FkIngredientSpec { get; set; }
        [Column("fkFoodItem", TypeName = "char(40)")]
        public string FkFoodItem { get; set; }
        [Column("isCritical")]
        public bool? IsCritical { get; set; }
        [Column("fkFICTerm", TypeName = "char(40)")]
        public string FkFicterm { get; set; }
        [Column("fkFICTermAlias", TypeName = "char(40)")]
        public string FkFictermAlias { get; set; }
        public double? TotalSolids { get; set; }
    }
}
