using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditUserNotificationML")]
    public partial class AuditUserNotificationMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        [Column("fkAuditUserNotification", TypeName = "char(40)")]
        public string FkAuditUserNotification { get; set; }
    }
}
