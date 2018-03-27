using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdEventHistory")]
    public partial class NpdEventHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("ResourceID", TypeName = "char(40)")]
        public string ResourceId { get; set; }
        [StringLength(100)]
        public string Category { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOfOperation { get; set; }
        [StringLength(512)]
        public string Action { get; set; }
        [Column("UserID", TypeName = "char(40)")]
        public string UserId { get; set; }
    }
}
