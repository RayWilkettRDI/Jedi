using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditCoverPageFields")]
    public partial class AuditCoverPageFields
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2048)]
        public string UserValue { get; set; }
        [Column("fkAuditScorecard", TypeName = "char(40)")]
        public string FkAuditScorecard { get; set; }
        [Column("fkAuditCoverPageFieldTemplate", TypeName = "char(40)")]
        public string FkAuditCoverPageFieldTemplate { get; set; }
    }
}
