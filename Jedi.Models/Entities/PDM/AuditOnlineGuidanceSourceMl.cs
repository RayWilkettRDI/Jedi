using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditOnlineGuidanceSourceML")]
    public partial class AuditOnlineGuidanceSourceMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("description")]
        [StringLength(256)]
        public string Description { get; set; }
        [Column("url")]
        [StringLength(1024)]
        public string Url { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
