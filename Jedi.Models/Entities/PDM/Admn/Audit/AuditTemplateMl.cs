using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditTemplateML")]
    public partial class AuditTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2048)]
        public string SpecialNotes { get; set; }
        [StringLength(1024)]
        public string Category { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkAuditTemplate", TypeName = "char(40)")]
        public string FkAuditTemplate { get; set; }
        [StringLength(1024)]
        public string Scope { get; set; }
        [StringLength(1024)]
        public string CategoryAspect { get; set; }
    }
}
