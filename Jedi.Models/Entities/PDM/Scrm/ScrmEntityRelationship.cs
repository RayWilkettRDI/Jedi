using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmEntityRelationship")]
    public partial class ScrmEntityRelationship
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkRelationship", TypeName = "char(40)")]
        public string FkRelationship { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkChild", TypeName = "char(40)")]
        public string FkChild { get; set; }
    }
}
