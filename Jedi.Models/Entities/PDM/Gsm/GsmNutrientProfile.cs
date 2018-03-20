using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmNutrientProfile")]
    public partial class GsmNutrientProfile
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? LabelWeightVolumeMajor { get; set; }
        [Column("fkLabelMajorUOM", TypeName = "char(40)")]
        public string FkLabelMajorUom { get; set; }
        public double? LabelWeightVolumeMinor { get; set; }
        [Column("fkAmountPerServingMajorUOM", TypeName = "char(40)")]
        public string FkAmountPerServingMajorUom { get; set; }
        public double? AmountPerServingMajor { get; set; }
        [Column("fkAmountPerServingMinorUOM", TypeName = "char(40)")]
        public string FkAmountPerServingMinorUom { get; set; }
        [Column("fkLabelMinorUOM", TypeName = "char(40)")]
        public string FkLabelMinorUom { get; set; }
        public double? AmountPerServingMinor { get; set; }
        public double? ServingsPerPack { get; set; }
        [Column("fkLabelVolumeMinorUOM", TypeName = "char(40)")]
        public string FkLabelVolumeMinorUom { get; set; }
        [Column("fkLabelVolumeMajorUOM", TypeName = "char(40)")]
        public string FkLabelVolumeMajorUom { get; set; }
        public double? LabelVolumeMajor { get; set; }
        public double? LabelVolumeMinor { get; set; }
        public double? LabelWeightMinor { get; set; }
        [Column("fkLabelWeightMajorUOM", TypeName = "char(40)")]
        public string FkLabelWeightMajorUom { get; set; }
        [Column("fkLabelWeightMinorUOM", TypeName = "char(40)")]
        public string FkLabelWeightMinorUom { get; set; }
        public double? LabelWeightMajor { get; set; }
        [Column("RACCValue")]
        public double? Raccvalue { get; set; }
        [Column("fkRaccUOM", TypeName = "char(40)")]
        public string FkRaccUom { get; set; }
        [Column("fkLabelClaimsClass", TypeName = "char(40)")]
        public string FkLabelClaimsClass { get; set; }
        [Column("fkNutrientMesurementUOM", TypeName = "char(40)")]
        public string FkNutrientMesurementUom { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
    }
}
