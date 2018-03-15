using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmWorkflowActivityTemplates")]
    public partial class GsmWorkflowActivityTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Position { get; set; }
        [Column("IsSplitOR")]
        public bool? IsSplitOr { get; set; }
        public bool? IsStart { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("fkWorkflowStatus", TypeName = "char(40)")]
        public string FkWorkflowStatus { get; set; }
        [Column("IsJoinOR")]
        public bool? IsJoinOr { get; set; }
        [Column("fkProcessTemplate", TypeName = "char(40)")]
        public string FkProcessTemplate { get; set; }
        public bool? CanHold { get; set; }
        [Column("AmberSLA")]
        public int? AmberSla { get; set; }
        [Column("RedSLA")]
        public int? RedSla { get; set; }
        public bool? IsTerminal { get; set; }
        public bool? Active { get; set; }
        [StringLength(20)]
        public string NotificationResolutionStrategy { get; set; }
        [StringLength(20)]
        public string SignatureDocResolutionStrategy { get; set; }
        [StringLength(20)]
        public string OwnerResolutionStrategy { get; set; }
    }
}
