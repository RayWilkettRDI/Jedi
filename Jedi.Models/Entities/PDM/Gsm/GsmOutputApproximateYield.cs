using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmOutputApproximateYield")]
    public partial class GsmOutputApproximateYield
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        public double? FinalTotalSolidsOverride { get; set; }
        public double? ProcessingLossFactor { get; set; }
        public double? WaterGainLossFactor { get; set; }
        [Column("fkOutputItem", TypeName = "char(40)")]
        public string FkOutputItem { get; set; }
        public double? ApproxYieldQty { get; set; }
        public double? BeginBatchSizeQty { get; set; }
        public double? InitialTotalSolids { get; set; }
        public double? FinalTotalSolids { get; set; }
        public double? LabeledUnits { get; set; }
        public double? TradedUnits { get; set; }
        public double? EdiblePortionOverride { get; set; }
        public double? TheoreticalEdiblePortion { get; set; }
        public double? SolidsGainLossFactor { get; set; }
    }
}
