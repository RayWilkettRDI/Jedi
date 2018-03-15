using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmPackagingAttributeTU")]
    public partial class GsmPackagingAttributeTu
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? CasesPerLayer { get; set; }
        [Column("fkPalletHeightUOM", TypeName = "char(40)")]
        public string FkPalletHeightUom { get; set; }
        [Column("fkCaseLengthDepthUOM", TypeName = "char(40)")]
        public string FkCaseLengthDepthUom { get; set; }
        public int? NumberOfLayers { get; set; }
        [Column("fkCaseGrossWeightUOM", TypeName = "char(40)")]
        public string FkCaseGrossWeightUom { get; set; }
        public double? PalletGrossWeight { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public double? CaseContents { get; set; }
        public double? CaseHeight { get; set; }
        public double? CaseLengthDepth { get; set; }
        [Column("fkCaseHeightUOM", TypeName = "char(40)")]
        public string FkCaseHeightUom { get; set; }
        public double? PalletHeight { get; set; }
        [Column("fkPackagingType", TypeName = "char(40)")]
        public string FkPackagingType { get; set; }
        public double? CaseWidth { get; set; }
        [Column("fkCaseWidthUOM", TypeName = "char(40)")]
        public string FkCaseWidthUom { get; set; }
        public double? CaseGrossWeight { get; set; }
        [Column("fkPalletGrossWeightUOM", TypeName = "char(40)")]
        public string FkPalletGrossWeightUom { get; set; }
        public double? PalletWidth { get; set; }
        public double? PalletLength { get; set; }
        [Column("fkPalletWidthUOM", TypeName = "char(40)")]
        public string FkPalletWidthUom { get; set; }
        [Column("fkPalletLengthUOM", TypeName = "char(40)")]
        public string FkPalletLengthUom { get; set; }
        [Column("fkPalletConfig", TypeName = "char(40)")]
        public string FkPalletConfig { get; set; }
        [Column("fkPackagingMaterialType", TypeName = "char(40)")]
        public string FkPackagingMaterialType { get; set; }
        [Column("fkTradedUnitProductType", TypeName = "char(40)")]
        public string FkTradedUnitProductType { get; set; }
        public double? CaseVolume { get; set; }
        public double? PalletVolume { get; set; }
        [Column("fkCaseVolumeUOM", TypeName = "char(40)")]
        public string FkCaseVolumeUom { get; set; }
        [Column("fkPalletVolumeUOM", TypeName = "char(40)")]
        public string FkPalletVolumeUom { get; set; }
        public double? CaseNetWeight { get; set; }
        public double? PalletNetWeight { get; set; }
        [Column("fkCaseNetWeightUOM", TypeName = "char(40)")]
        public string FkCaseNetWeightUom { get; set; }
        [Column("fkPalletNetWeightUOM", TypeName = "char(40)")]
        public string FkPalletNetWeightUom { get; set; }
        [Column("TotalGrossWeightWOPallet")]
        public double? TotalGrossWeightWopallet { get; set; }
        [Column("fkTotalGrossWeightWOPalletUOM", TypeName = "char(40)")]
        public string FkTotalGrossWeightWopalletUom { get; set; }
        public double? ModeStackingHeight { get; set; }
        public double? WarehouseStackingHeight { get; set; }
        [Column("caseMinNetWeight")]
        public double? CaseMinNetWeight { get; set; }
        [Column("fkCaseMinNetWeightUOM", TypeName = "char(40)")]
        public string FkCaseMinNetWeightUom { get; set; }
        [Column("caseMaxNetWeight")]
        public double? CaseMaxNetWeight { get; set; }
        [Column("fkCaseMaxNetWeightUOM", TypeName = "char(40)")]
        public string FkCaseMaxNetWeightUom { get; set; }
        [Column("fkVariableWeightType", TypeName = "char(40)")]
        public string FkVariableWeightType { get; set; }
        [Column("isVariableWeight")]
        public bool? IsVariableWeight { get; set; }
        public double? TareWeight { get; set; }
        [Column("fkTareWeightUOM", TypeName = "char(40)")]
        public string FkTareWeightUom { get; set; }
    }
}
