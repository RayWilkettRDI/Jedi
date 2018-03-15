using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class NutrientOptConstraints
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkNutrient", TypeName = "char(40)")]
        public string FkNutrient { get; set; }
        [StringLength(3)]
        public string Operator { get; set; }
        public int? HandlingUnit { get; set; }
        public double? NutrientValueQuantity { get; set; }
        public int? Sequence { get; set; }
        [Column("fkNutrientValueUom", TypeName = "char(40)")]
        public string FkNutrientValueUom { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
    }
}
