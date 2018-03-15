using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLFoodGroupML")]
    public partial class FclfoodGroupMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(24)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkFCLFoodGroup", TypeName = "char(40)")]
        public string FkFclfoodGroup { get; set; }
    }
}
