using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmSignatureRequests")]
    public partial class PlmSignatureRequests
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [StringLength(2000)]
        public string LastWorkflowActionComments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastWorkflowActionDate { get; set; }
        [Column("fkFunctionalArea", TypeName = "char(40)")]
        public string FkFunctionalArea { get; set; }
        [Column("SLARedDays")]
        public int? SlaredDays { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("SLAAmberDays")]
        public int? SlaamberDays { get; set; }
        [Column("OwningEntityPKID", TypeName = "char(40)")]
        public string OwningEntityPkid { get; set; }
        [Column("fkLastWorkflowActionUser", TypeName = "char(40)")]
        public string FkLastWorkflowActionUser { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        [Column("AuditHistoryPKID", TypeName = "char(40)")]
        public string AuditHistoryPkid { get; set; }
    }
}
