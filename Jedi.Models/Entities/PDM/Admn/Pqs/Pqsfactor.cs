using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSFactor")]
    public partial class Pqsfactor
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("FactorID")]
        public int? FactorId { get; set; }
        public double? UpperLimit { get; set; }
        [Column("fkSection", TypeName = "char(40)")]
        public string FkSection { get; set; }
        [StringLength(50)]
        public string AnalyticalPropertyNumber { get; set; }
        public int? SequenceNumber { get; set; }
        public double? DefaultScore { get; set; }
        public double? Target { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        public double? NonConformanceScoringLimit { get; set; }
        public int? FactorType { get; set; }
        [Column(TypeName = "char(1)")]
        public string SubType { get; set; }
        [StringLength(1000)]
        public string SpecLimits { get; set; }
        [StringLength(256)]
        public string CalculationFormula { get; set; }
        [StringLength(1000)]
        public string TestUsed { get; set; }
        [StringLength(64)]
        public string ScoringFormula { get; set; }
        public double? Weight { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column(TypeName = "char(3)")]
        public string InputDataTypeCode { get; set; }
        public double? LowerLimit { get; set; }
    }
}
