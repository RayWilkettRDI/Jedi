using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("theoreticalNutrition")]
    public partial class TheoreticalNutrition
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Required]
        [Column("fkNutrient", TypeName = "char(40)")]
        public string FkNutrient { get; set; }
        [Column("value")]
        public double? Value { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("isConstitutionComplete")]
        public bool? IsConstitutionComplete { get; set; }
    }
}
