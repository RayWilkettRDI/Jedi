using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.TestingProtocol
{
    public partial class TestProtocolAnalyticalProperty
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkTestingProtocol", TypeName = "char(40)")]
        public string FkTestingProtocol { get; set; }
        [Column("sequence")]
        public int Sequence { get; set; }
        public double? LowerLimit { get; set; }
        public double? Target { get; set; }
        [StringLength(256)]
        public string Formula { get; set; }
        public double? ScoringWeight { get; set; }
        [Column("TPID")]
        public int? Tpid { get; set; }
        public double? UpperLimit { get; set; }
        [StringLength(2000)]
        public string SpecLimits { get; set; }
        [Column("fkScoringMethod", TypeName = "char(40)")]
        public string FkScoringMethod { get; set; }
        [Column("fkTestingProtocolSection", TypeName = "char(40)")]
        public string FkTestingProtocolSection { get; set; }
        [Column("fkLimitsUOM", TypeName = "char(40)")]
        public string FkLimitsUom { get; set; }
        [StringLength(1000)]
        public string TestUsed { get; set; }
        [Column("ScoringNC")]
        [StringLength(5)]
        public string ScoringNc { get; set; }
        public int? NonConformanceScore { get; set; }
        [Column("fkExtendedAttributeType", TypeName = "char(40)")]
        public string FkExtendedAttributeType { get; set; }
    }
}
