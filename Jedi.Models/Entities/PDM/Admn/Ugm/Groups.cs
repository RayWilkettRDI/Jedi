using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Groups
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("fkGroup", TypeName = "char(40)")]
        public string FkGroup { get; set; }
        public int? Status { get; set; }
        [Column("inheritsParentPrivileges")]
        public bool? InheritsParentPrivileges { get; set; }
    }
}
