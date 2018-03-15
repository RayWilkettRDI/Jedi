using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLFoodNutrientValue")]
    public partial class FclfoodNutrientValue
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("NutrientID")]
        [StringLength(24)]
        public string NutrientId { get; set; }
        [Column("FoodItemID")]
        [StringLength(24)]
        public string FoodItemId { get; set; }
        [Column("fkFCLNutrient", TypeName = "char(40)")]
        public string FkFclnutrient { get; set; }
        [Column("fkFCLFoodItem", TypeName = "char(40)")]
        public string FkFclfoodItem { get; set; }
        public double? Value { get; set; }
        [Column("SourceID")]
        [StringLength(24)]
        public string SourceId { get; set; }
    }
}
