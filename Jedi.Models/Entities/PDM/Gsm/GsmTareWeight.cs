using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmTareWeight")]
    public partial class GsmTareWeight
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? ReferenceWeight { get; set; }
        public double? TareWeight { get; set; }
        [Column("fkTareWeightBaseUOM", TypeName = "char(40)")]
        public string FkTareWeightBaseUom { get; set; }
        public double? TareWeightBase { get; set; }
        [Column("fkTareWeightUOM", TypeName = "char(40)")]
        public string FkTareWeightUom { get; set; }
        [Column("fkReferenceWeightUOM", TypeName = "char(40)")]
        public string FkReferenceWeightUom { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
    }
}
