using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLNutrientML")]
    public partial class FclnutrientMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(48)]
        public string Name { get; set; }
        [Column("fkFCLNutrient", TypeName = "char(40)")]
        public string FkFclnutrient { get; set; }
    }
}
