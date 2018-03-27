using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.NutrientProfile
{
    [Table("gsmNutrientComposite")]
    public partial class GsmNutrientComposite
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompositeDate { get; set; }
    }
}
