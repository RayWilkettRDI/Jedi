using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditCriterionScoringRules")]
    public partial class AuditCriterionScoringRules
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? SequenceNumber { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        public double? Value { get; set; }
        public double? Score { get; set; }
        [Column("fkCriterion")]
        [StringLength(40)]
        public string FkCriterion { get; set; }
        public int? Operator { get; set; }
    }
}
