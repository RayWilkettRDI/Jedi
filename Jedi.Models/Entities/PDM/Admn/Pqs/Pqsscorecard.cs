using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSScorecard")]
    public partial class Pqsscorecard
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("ScoredLangID")]
        public int? ScoredLangId { get; set; }
        public bool? InputComplete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScoredDate { get; set; }
        [Column(TypeName = "char(7)")]
        public string ScorecardNumber { get; set; }
        public bool? NonConformant { get; set; }
        public double? Score { get; set; }
        [Column("fkTemplate", TypeName = "char(40)")]
        public string FkTemplate { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkScoredBy", TypeName = "char(40)")]
        public string FkScoredBy { get; set; }
        [StringLength(1024)]
        public string Notes { get; set; }
        [Column("fkSample", TypeName = "char(40)")]
        public string FkSample { get; set; }
        [Column("fkScorecardType", TypeName = "char(40)")]
        public string FkScorecardType { get; set; }
        [Column("fkScorecardQualification", TypeName = "char(40)")]
        public string FkScorecardQualification { get; set; }
        [Column("fkScoringLocation", TypeName = "char(40)")]
        public string FkScoringLocation { get; set; }
        [StringLength(100)]
        public string PanelistName { get; set; }
        public bool? MarkedAsDeleted { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
