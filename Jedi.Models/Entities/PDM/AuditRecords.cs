using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class AuditRecords
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("actor")]
        [StringLength(50)]
        public string Actor { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [Column("fkDataObject", TypeName = "char(40)")]
        public string FkDataObject { get; set; }
    }
}
