using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmTradedUnit")]
    public partial class GsmTradedUnit
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? CaseWidth { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public double? CaseHeight { get; set; }
        public double? PalletWeight { get; set; }
        [Column("PalletWeightUOM")]
        [StringLength(50)]
        public string PalletWeightUom { get; set; }
        [Column("CaseWidthUOMID", TypeName = "char(40)")]
        public string CaseWidthUomid { get; set; }
        public int? CasesLayer { get; set; }
        public double? CaseGrossWeight { get; set; }
        public double? CaseLength { get; set; }
        [Column("CaseLengthUOMID", TypeName = "char(40)")]
        public string CaseLengthUomid { get; set; }
        [Column("PalletHeightUOMID", TypeName = "char(40)")]
        public string PalletHeightUomid { get; set; }
        [Column("CaseGrossWeightUOM")]
        [StringLength(50)]
        public string CaseGrossWeightUom { get; set; }
        public double? PalletHeight { get; set; }
        public int? CaseContents { get; set; }
        [Column("CaseHeightUOMID", TypeName = "char(40)")]
        public string CaseHeightUomid { get; set; }
        public int? NumberLayers { get; set; }
        [Column("fkPalletType", TypeName = "char(40)")]
        public string FkPalletType { get; set; }
    }
}
