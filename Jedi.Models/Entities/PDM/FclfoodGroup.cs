using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLFoodGroup")]
    public partial class FclfoodGroup
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("FoodGroupID")]
        [StringLength(24)]
        public string FoodGroupId { get; set; }
        [Column("SourceID")]
        [StringLength(24)]
        public string SourceId { get; set; }
    }
}
