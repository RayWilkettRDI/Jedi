using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditTemplates")]
    public partial class AuditTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(20)]
        public string ShemaVersion { get; set; }
        [Column(TypeName = "char(7)")]
        public string TemplateNumber { get; set; }
        public bool? ShowScoring { get; set; }
        public bool? IsPublic { get; set; }
    }
}
