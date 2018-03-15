using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditCriterionScoringRuleML")]
    public partial class AuditCriterionScoringRuleMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkCriterionScoringRule", TypeName = "char(40)")]
        public string FkCriterionScoringRule { get; set; }
        [Column("name")]
        [StringLength(256)]
        public string Name { get; set; }
    }
}
