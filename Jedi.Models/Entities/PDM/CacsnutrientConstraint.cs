using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("CACSNutrientConstraint")]
    public partial class CacsnutrientConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? ConstraintOperator { get; set; }
        [Column("fkNutrient", TypeName = "char(40)")]
        public string FkNutrient { get; set; }
        public double? ConstraintValue { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
    }
}
