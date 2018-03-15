using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmCUPackagingAttributes")]
    public partial class GsmCupackagingAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? LabelSizeWeight { get; set; }
        public double? ContainerNetWeight { get; set; }
        [Column("ShelfLifeUOM")]
        public int? ShelfLifeUom { get; set; }
        public double? ShelfLife { get; set; }
        [Column("ContainerNetWeightUOM")]
        [StringLength(50)]
        public string ContainerNetWeightUom { get; set; }
        [Column("LabelSizeWeightUOM")]
        [StringLength(50)]
        public string LabelSizeWeightUom { get; set; }
        public int? InnerPack { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
    }
}
