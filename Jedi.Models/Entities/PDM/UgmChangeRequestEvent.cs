using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ugmChangeRequestEvent")]
    public partial class UgmChangeRequestEvent
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("fkChangeRequest", TypeName = "char(40)")]
        public string FkChangeRequest { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
    }
}
