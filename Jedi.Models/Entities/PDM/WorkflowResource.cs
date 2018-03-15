using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class WorkflowResource
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("resourceID", TypeName = "char(40)")]
        public string ResourceId { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Required]
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
    }
}
