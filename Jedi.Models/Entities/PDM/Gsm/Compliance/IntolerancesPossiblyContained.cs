using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class IntolerancesPossiblyContained
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? MaxPer100g { get; set; }
        [Column("fkIntolerance", TypeName = "char(40)")]
        public string FkIntolerance { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkMaxPer100gUOM", TypeName = "char(40)")]
        public string FkMaxPer100gUom { get; set; }
        [Column("comments")]
        [StringLength(256)]
        public string Comments { get; set; }
    }
}
