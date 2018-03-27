using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("EQPackagingWastes")]
    public partial class EqpackagingWastes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? PcntComposedOfRecyclables { get; set; }
        public double? PercentRecyclable { get; set; }
        public double? Weight { get; set; }
        [StringLength(10)]
        public string UnitMeasure { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("fkWasteClass", TypeName = "char(40)")]
        public string FkWasteClass { get; set; }
        [Column("fkUnitMeasureUOM", TypeName = "char(40)")]
        public string FkUnitMeasureUom { get; set; }
    }
}
