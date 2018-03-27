using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("dwbLIOAdjustments")]
    public partial class DwbLioadjustments
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkSourceComponent", TypeName = "char(40)")]
        public string FkSourceComponent { get; set; }
        [Column("fkTargetComponent", TypeName = "char(40)")]
        public string FkTargetComponent { get; set; }
        public double? AdjustmentPct { get; set; }
    }
}
