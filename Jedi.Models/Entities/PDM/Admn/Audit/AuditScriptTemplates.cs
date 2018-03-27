using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditScriptTemplates")]
    public partial class AuditScriptTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("status")]
        [StringLength(10)]
        public string Status { get; set; }
        public int? SeqNo { get; set; }
        [StringLength(10)]
        public string ScriptNumber { get; set; }
        public bool? EvaluateAllConditions { get; set; }
    }
}
