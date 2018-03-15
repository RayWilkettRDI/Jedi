using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditCriterionML")]
    public partial class AuditCriterionMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2048)]
        public string Description { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(2048)]
        public string Guidance { get; set; }
        [Column("fkAuditCriterion", TypeName = "char(40)")]
        public string FkAuditCriterion { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(2048)]
        public string ConformanceLanguage { get; set; }
        [StringLength(2048)]
        public string NonConformanceLanguage { get; set; }
    }
}
