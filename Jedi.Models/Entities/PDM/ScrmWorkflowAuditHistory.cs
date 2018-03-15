using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("scrmWorkflowAuditHistory")]
    public partial class ScrmWorkflowAuditHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [Column(TypeName = "char(40)")]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [Column("DocumentID", TypeName = "char(40)")]
        public string DocumentId { get; set; }
        [Column(TypeName = "char(40)")]
        public string NewStatus { get; set; }
    }
}
