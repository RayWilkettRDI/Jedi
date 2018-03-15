using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmTheoreticalYield")]
    public partial class GsmTheoreticalYield
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFinalRelativeDensityVolUOM", TypeName = "char(40)")]
        public string FkFinalRelativeDensityVolUom { get; set; }
        public double? BeginPercentTotalSolids { get; set; }
        public double? FinalRelativeDensityMassValue { get; set; }
        public double? TheoreticalYield { get; set; }
        public double? WaterGainLossFactor { get; set; }
        public double? ProcessingLossFactor { get; set; }
        [Column("fkFinalRelativeDensityMassUOM", TypeName = "char(40)")]
        public string FkFinalRelativeDensityMassUom { get; set; }
        public double? FinalPercentTotalSolids { get; set; }
        public double? FinalRelativeDensityVolValue { get; set; }
        [Column("fkProcessSheet", TypeName = "char(40)")]
        public string FkProcessSheet { get; set; }
        public double? LabeledUnitsPerBatch { get; set; }
        public double? TradedUnitsPerBatch { get; set; }
        public double? FinalRelDensOverrideVolValue { get; set; }
        public double? FinalRelDensOverrideMassValue { get; set; }
        [Column("fkFinalRelDensOverrideMassUOM", TypeName = "char(40)")]
        public string FkFinalRelDensOverrideMassUom { get; set; }
        [Column("fkFinalRelDensOverrideVolUOM", TypeName = "char(40)")]
        public string FkFinalRelDensOverrideVolUom { get; set; }
    }
}
