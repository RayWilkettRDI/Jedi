using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmNutrientCompositeItem")]
    public partial class GsmNutrientCompositeItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        public int? Weighting { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompositeDate { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("fkFacility", TypeName = "char(40)")]
        public string FkFacility { get; set; }
    }
}
