using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ugmGroupChangeRequest")]
    public partial class UgmGroupChangeRequest
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParentGroup", TypeName = "char(40)")]
        public string FkParentGroup { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("action")]
        [StringLength(10)]
        public string Action { get; set; }
        [Column("fkTargetGroup", TypeName = "char(40)")]
        public string FkTargetGroup { get; set; }
        [Column("unused1")]
        [StringLength(1)]
        public string Unused1 { get; set; }
        [Column("fkWorkflowOwner", TypeName = "char(40)")]
        public string FkWorkflowOwner { get; set; }
        [Column("inheritsParentPrivileges")]
        public bool? InheritsParentPrivileges { get; set; }
    }
}
