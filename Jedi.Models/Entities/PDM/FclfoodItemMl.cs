using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLFoodItemML")]
    public partial class FclfoodItemMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkFCLFoodItem", TypeName = "char(40)")]
        public string FkFclfoodItem { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
    }
}
