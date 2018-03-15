using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FoodServiceStandardTypeML")]
    public partial class FoodServiceStandardTypeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFoodServiceStandard", TypeName = "char(40)")]
        public string FkFoodServiceStandard { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
    }
}
