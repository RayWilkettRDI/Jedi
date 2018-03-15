using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SpecActivitySpecification
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkInitiatingSpec", TypeName = "char(40)")]
        public string FkInitiatingSpec { get; set; }
        [Column("fkActivityTargetStatus", TypeName = "char(40)")]
        public string FkActivityTargetStatus { get; set; }
        [Column("fkSpecTargetStatus", TypeName = "char(40)")]
        public string FkSpecTargetStatus { get; set; }
        public bool? ProcessDependency { get; set; }
        [StringLength(1024)]
        public string SpecialNotes { get; set; }
        public bool? NotifySpecReader { get; set; }
        public bool? HideInactiveSpec { get; set; }
    }
}
