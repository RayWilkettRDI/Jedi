using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Ugm
{
    [Table("GroupsML")]
    public partial class GroupsMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkGroup", TypeName = "char(40)")]
        public string FkGroup { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(500)]
        public string CanonicalName { get; set; }
    }
}
