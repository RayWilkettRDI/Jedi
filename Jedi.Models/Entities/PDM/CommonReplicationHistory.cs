using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonReplicationHistory")]
    public partial class CommonReplicationHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinishTime { get; set; }
        [StringLength(50)]
        public string Source { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }
        public int? LastSourceTransactionId { get; set; }
        public int? NewSourceTransactionId { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        public int? NewTargetTransactionId { get; set; }
        public int? LastTargetTransactionId { get; set; }
    }
}
