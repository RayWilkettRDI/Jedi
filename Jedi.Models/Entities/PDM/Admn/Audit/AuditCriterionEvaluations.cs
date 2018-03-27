using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditCriterionEvaluations")]
    public partial class AuditCriterionEvaluations
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAuditCriterion", TypeName = "char(40)")]
        public string FkAuditCriterion { get; set; }
        [StringLength(1024)]
        public string Observation { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        public double? Score { get; set; }
        public double? CalculatedValue { get; set; }
        [StringLength(2048)]
        public string Comments { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("fkCorrectiveActionProtocol", TypeName = "char(40)")]
        public string FkCorrectiveActionProtocol { get; set; }
    }
}
