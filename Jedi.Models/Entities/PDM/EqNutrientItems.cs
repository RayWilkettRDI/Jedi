using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqNutrientItems")]
    public partial class EqNutrientItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("fkValueUOM", TypeName = "char(40)")]
        public string FkValueUom { get; set; }
        [Column("fkNutrient", TypeName = "char(40)")]
        public string FkNutrient { get; set; }
        [StringLength(256)]
        public string Comments { get; set; }
        public double? Value { get; set; }
        public int? ItemExists { get; set; }
    }
}
