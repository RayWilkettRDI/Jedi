using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLFoodItem")]
    public partial class FclfoodItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("SourceID")]
        [StringLength(24)]
        public string SourceId { get; set; }
        [Column("FoodItemID")]
        [StringLength(24)]
        public string FoodItemId { get; set; }
        [Column("fkFCLFoodGroup", TypeName = "char(40)")]
        public string FkFclfoodGroup { get; set; }
        [Column("FoodGroupID")]
        [StringLength(24)]
        public string FoodGroupId { get; set; }
    }
}
