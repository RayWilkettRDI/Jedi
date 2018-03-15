using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditTransitionTemplate")]
    public partial class AuditTransitionTemplate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? SequenceNumber { get; set; }
        [StringLength(1024)]
        public string Condition { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("fkDestinationScriptTemplate", TypeName = "char(40)")]
        public string FkDestinationScriptTemplate { get; set; }
        [Column("fkDestinationWorkflowStep", TypeName = "char(40)")]
        public string FkDestinationWorkflowStep { get; set; }
    }
}
