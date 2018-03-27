using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonLifecycleEventLog")]
    public partial class CommonLifecycleEventLog
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("eventType")]
        public int EventType { get; set; }
        [Column("eventSource")]
        [StringLength(50)]
        public string EventSource { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [Column("fkActor", TypeName = "char(40)")]
        public string FkActor { get; set; }
        [Required]
        [Column("fkAffectedObject", TypeName = "char(40)")]
        public string FkAffectedObject { get; set; }
        [Column("reason")]
        [StringLength(256)]
        public string Reason { get; set; }
        [Column("fkRelatedObject", TypeName = "char(40)")]
        public string FkRelatedObject { get; set; }
    }
}
