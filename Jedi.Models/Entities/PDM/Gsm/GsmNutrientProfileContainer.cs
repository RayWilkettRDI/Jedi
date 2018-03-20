using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmNutrientProfileContainer")]
    public partial class GsmNutrientProfileContainer
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkActiveNutrientProfile", TypeName = "char(40)")]
        public string FkActiveNutrientProfile { get; set; }
    }
}
