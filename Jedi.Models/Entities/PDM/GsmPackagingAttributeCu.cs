using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmPackagingAttributeCU")]
    public partial class GsmPackagingAttributeCu
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("fkPackagingType", TypeName = "char(40)")]
        public string FkPackagingType { get; set; }
        public double? LabelSizeWeightMajor { get; set; }
        public double? Length { get; set; }
        [Column("fkLengthUOM", TypeName = "char(40)")]
        public string FkLengthUom { get; set; }
        [Column("fkWidthUOM", TypeName = "char(40)")]
        public string FkWidthUom { get; set; }
        [Column("fkLabelSizeWeightMajorUOM", TypeName = "char(40)")]
        public string FkLabelSizeWeightMajorUom { get; set; }
        public double? ContainerNetWeightMajor { get; set; }
        public double? LabelSizeWeightMinor { get; set; }
        [Column("fkContainerNetWeightMinorUOM", TypeName = "char(40)")]
        public string FkContainerNetWeightMinorUom { get; set; }
        [Column("fkHeightUOM", TypeName = "char(40)")]
        public string FkHeightUom { get; set; }
        public double? ContainerNetWeightMinor { get; set; }
        public double? Width { get; set; }
        [Column("fkContainerNetWeightMajorUOM", TypeName = "char(40)")]
        public string FkContainerNetWeightMajorUom { get; set; }
        public double? Height { get; set; }
        [Column("fkLabelSizeWeightMinorUOM", TypeName = "char(40)")]
        public string FkLabelSizeWeightMinorUom { get; set; }
        public double? InnerPack { get; set; }
        public double? LabelWeightMajor { get; set; }
        [Column("fkLabelVolumeMajorUOM", TypeName = "char(40)")]
        public string FkLabelVolumeMajorUom { get; set; }
        [Column("fkLabelWeightMinorUOM", TypeName = "char(40)")]
        public string FkLabelWeightMinorUom { get; set; }
        public double? LabelVolumeMinor { get; set; }
        public double? LabelWeightMinor { get; set; }
        [Column("fkLabelVolumeMinorUOM", TypeName = "char(40)")]
        public string FkLabelVolumeMinorUom { get; set; }
        public double? LabelVolumeMajor { get; set; }
        [Column("fkLabelWeightMajorUOM", TypeName = "char(40)")]
        public string FkLabelWeightMajorUom { get; set; }
        [StringLength(50)]
        public string InnerPackLabelText { get; set; }
        [Column("fkPackagingMaterialType", TypeName = "char(40)")]
        public string FkPackagingMaterialType { get; set; }
        public double? GrossWeight { get; set; }
        [Column("fkGrossWeightUOM", TypeName = "char(40)")]
        public string FkGrossWeightUom { get; set; }
        [Column("fkVolumeUOM", TypeName = "char(40)")]
        public string FkVolumeUom { get; set; }
        public double? Volume { get; set; }
        [Column("fkTareWeightUOM", TypeName = "char(40)")]
        public string FkTareWeightUom { get; set; }
        public double? TareWeight { get; set; }
        public double? ContainerMinNetWeight { get; set; }
        public bool? IsVariableWeight { get; set; }
        [Column("fkContainerMinNetWeightUOM", TypeName = "char(40)")]
        public string FkContainerMinNetWeightUom { get; set; }
        [Column("fkContainerMaxNetWeightUOM", TypeName = "char(40)")]
        public string FkContainerMaxNetWeightUom { get; set; }
        [Column("fkVariableWeightType", TypeName = "char(40)")]
        public string FkVariableWeightType { get; set; }
        public double? ContainerMaxNetWeight { get; set; }
    }
}
