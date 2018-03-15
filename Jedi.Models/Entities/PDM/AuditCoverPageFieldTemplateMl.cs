using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditCoverPageFieldTemplateML")]
    public partial class AuditCoverPageFieldTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(2048)]
        public string Value { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public int? CoverPageFieldOrder { get; set; }
        [Column("fkCoverPageFieldTemplate", TypeName = "char(40)")]
        public string FkCoverPageFieldTemplate { get; set; }
    }
}
