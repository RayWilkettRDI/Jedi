using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    public partial class WorkflowTransitionResource
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("resourceID", TypeName = "char(40)")]
        public string ResourceId { get; set; }
        [Required]
        [Column("fkTransitionData", TypeName = "char(40)")]
        public string FkTransitionData { get; set; }
    }
}
