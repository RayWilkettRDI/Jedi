using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbBreakdown")]
    public partial class DwbBreakdown
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? TotalSolids { get; set; }
        [StringLength(2048)]
        public string Name { get; set; }
        [Column("fkDWBSpecAttribute", TypeName = "char(40)")]
        public string FkDwbspecAttribute { get; set; }
        public double? Value { get; set; }
        public double? PercentCompostion { get; set; }
        [StringLength(128)]
        public string ComponentDescription { get; set; }
        [Column("fkFICTerm", TypeName = "char(40)")]
        public string FkFicterm { get; set; }
        [Column("fkIngSpec", TypeName = "char(40)")]
        public string FkIngSpec { get; set; }
        [Column("ID")]
        [StringLength(128)]
        public string Id { get; set; }
        [Column("fkFICTermAlias", TypeName = "char(40)")]
        public string FkFictermAlias { get; set; }
        [Column("fkComponentFunction", TypeName = "char(40)")]
        public string FkComponentFunction { get; set; }
        public int? Sequence { get; set; }
        [Column("fkFoodItem", TypeName = "char(40)")]
        public string FkFoodItem { get; set; }
        [Column("isCritical")]
        public bool? IsCritical { get; set; }
    }
}
