using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Lio
{
    [Table("LIOElementSources")]
    public partial class LioelementSources
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? PercentTotalFormulation { get; set; }
        [Column("fkSourceSpec", TypeName = "char(40)")]
        public string FkSourceSpec { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public double? TotalSolids { get; set; }
        [Column(TypeName = "char(40)")]
        public string BreakdownSummaryPkid { get; set; }
        public double? SolidsGainLossFactor { get; set; }
        public double? ProcessingLossFactor { get; set; }
        public double? WaterGainLossFactor { get; set; }
    }
}
