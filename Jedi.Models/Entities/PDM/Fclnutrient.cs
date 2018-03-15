using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLNutrient")]
    public partial class Fclnutrient
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("InFoodsID")]
        [StringLength(24)]
        public string InFoodsId { get; set; }
        [Column("NutrientID")]
        [StringLength(24)]
        public string NutrientId { get; set; }
        [Column("SourceID")]
        [StringLength(24)]
        public string SourceId { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
    }
}
