using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbNutrient")]
    public partial class DwbNutrient
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? GainLossFactor { get; set; }
        public int? StandardNutrientSequenceNumber { get; set; }
        public double? Value { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("GSMID")]
        [StringLength(40)]
        public string Gsmid { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkSpecAttributes", TypeName = "char(40)")]
        public string FkSpecAttributes { get; set; }
        [Column("fkSupplementaryParent", TypeName = "char(40)")]
        public string FkSupplementaryParent { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
