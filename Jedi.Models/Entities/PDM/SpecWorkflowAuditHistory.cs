using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SpecWorkflowAuditHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("status", TypeName = "char(40)")]
        public string Status { get; set; }
        [Required]
        [Column("userName")]
        [StringLength(100)]
        public string UserName { get; set; }
        [Column("activityDate", TypeName = "datetime")]
        public DateTime ActivityDate { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [Required]
        [Column("docID", TypeName = "char(40)")]
        public string DocId { get; set; }
        [Column(TypeName = "char(40)")]
        public string NewStatus { get; set; }
    }
}
