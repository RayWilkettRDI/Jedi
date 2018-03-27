using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmAuditHistory")]
    public partial class PlmAuditHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(64)]
        public string UserName { get; set; }
        [Column("DocumentID", TypeName = "char(40)")]
        public string DocumentId { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [StringLength(64)]
        public string EventName { get; set; }
    }
}
