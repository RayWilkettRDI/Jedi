using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditCoverPageFieldTemplates")]
    public partial class AuditCoverPageFieldTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsEditable { get; set; }
        [Column("fkAuditTemplate", TypeName = "char(40)")]
        public string FkAuditTemplate { get; set; }
        public int? FieldOrder { get; set; }
        [Column("dataType")]
        public int? DataType { get; set; }
    }
}
