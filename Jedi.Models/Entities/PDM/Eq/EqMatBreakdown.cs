using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqMatBreakdown")]
    public partial class EqMatBreakdown
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public double? MinRange { get; set; }
        public double? MaxRange { get; set; }
        public double? Formulation { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        [Column("fkComponentFunction", TypeName = "char(40)")]
        public string FkComponentFunction { get; set; }
        [StringLength(2048)]
        public string Description { get; set; }
        [StringLength(2048)]
        public string FreeTextDescription { get; set; }
        public bool? Critical { get; set; }
        public double? TotalSolids { get; set; }
        [Column("fkFICTerm", TypeName = "char(40)")]
        public string FkFicterm { get; set; }
        [Column("fkFoodItem", TypeName = "char(40)")]
        public string FkFoodItem { get; set; }
        [Column("fkFICTermAlias", TypeName = "char(40)")]
        public string FkFictermAlias { get; set; }
        [Column("fkIngredientSpec", TypeName = "char(40)")]
        public string FkIngredientSpec { get; set; }
        public int Sequence { get; set; }
    }
}
