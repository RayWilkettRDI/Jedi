using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditSectionTemplateML")]
    public partial class AuditSectionTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(2048)]
        public string Guidance { get; set; }
        [Column("fkAuditSectionTemplate", TypeName = "char(40)")]
        public string FkAuditSectionTemplate { get; set; }
        [StringLength(1024)]
        public string SectionApplicabilityYesAnswer { get; set; }
        [StringLength(1024)]
        public string SectionApplicabilityQuestion { get; set; }
        [StringLength(1024)]
        public string SectionApplicabilityNoAnswer { get; set; }
    }
}
