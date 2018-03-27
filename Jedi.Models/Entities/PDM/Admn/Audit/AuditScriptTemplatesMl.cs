using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditScriptTemplatesML")]
    public partial class AuditScriptTemplatesMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("description")]
        [StringLength(1024)]
        public string Description { get; set; }
        [Column("fkScript", TypeName = "char(40)")]
        public string FkScript { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
