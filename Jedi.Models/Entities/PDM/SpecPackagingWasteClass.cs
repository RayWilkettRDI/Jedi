using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specPackagingWasteClass")]
    public partial class SpecPackagingWasteClass
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkWasteClassID", TypeName = "char(40)")]
        public string FkWasteClassId { get; set; }
        public double Weight { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        public double? PercentRecyclable { get; set; }
        public double? PcntComposedOfRecyclables { get; set; }
        [Column("fkUnitMeasureUOM", TypeName = "char(40)")]
        public string FkUnitMeasureUom { get; set; }
    }
}
