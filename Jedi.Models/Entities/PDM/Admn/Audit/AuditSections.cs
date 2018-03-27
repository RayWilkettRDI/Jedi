using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditSections")]
    public partial class AuditSections
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAuditSectionTemplate", TypeName = "char(40)")]
        public string FkAuditSectionTemplate { get; set; }
        public double? WeightedScore { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [StringLength(2048)]
        public string Comments { get; set; }
        public double? Score { get; set; }
        [Column("isApplicable")]
        public bool? IsApplicable { get; set; }
        public bool? AskIfApplicablePreference { get; set; }
        [Column("fkSectionType", TypeName = "char(40)")]
        public string FkSectionType { get; set; }
    }
}
