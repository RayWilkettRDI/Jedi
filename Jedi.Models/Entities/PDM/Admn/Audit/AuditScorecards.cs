using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditScorecards")]
    public partial class AuditScorecards
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(40)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModificationDate { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        public double? Score { get; set; }
        [Column("fkAuditTemplate", TypeName = "char(40)")]
        public string FkAuditTemplate { get; set; }
    }
}
