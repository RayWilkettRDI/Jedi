using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditSectionTemplates")]
    public partial class AuditSectionTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? SectionOrder { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public bool? CanBeMarkedNotApplicable { get; set; }
        public bool? ScoresFullCreditWhenNotAppl { get; set; }
        [StringLength(50)]
        public string SectionNumber { get; set; }
        public double? Weight { get; set; }
        [Column("fkDefaultSectionType", TypeName = "char(40)")]
        public string FkDefaultSectionType { get; set; }
        public bool? IsRepeatable { get; set; }
    }
}
