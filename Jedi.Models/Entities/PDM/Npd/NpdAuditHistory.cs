using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdAuditHistory")]
    public partial class NpdAuditHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [StringLength(300)]
        public string EventName { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("DocumentID", TypeName = "char(40)")]
        public string DocumentId { get; set; }
        [StringLength(64)]
        public string UserName { get; set; }
        [Column("MultiPartAttachmentPKID", TypeName = "char(40)")]
        public string MultiPartAttachmentPkid { get; set; }
        [Column("fkFromStatus", TypeName = "char(40)")]
        public string FkFromStatus { get; set; }
        [Column("fkToStatus", TypeName = "char(40)")]
        public string FkToStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        public bool? ForwardTransition { get; set; }
    }
}
