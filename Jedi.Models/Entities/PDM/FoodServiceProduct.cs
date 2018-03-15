using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FoodServiceProduct
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("lasteditdate", TypeName = "char(10)")]
        public string Lasteditdate { get; set; }
        [Column("fkStandard", TypeName = "char(40)")]
        public string FkStandard { get; set; }
        [Column("fkNutrientMesurementUOM", TypeName = "char(40)")]
        public string FkNutrientMesurementUom { get; set; }
    }
}
