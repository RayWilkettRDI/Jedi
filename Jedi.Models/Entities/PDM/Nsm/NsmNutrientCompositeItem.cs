using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Nsm
{
    [Table("nsmNutrientCompositeItem")]
    public partial class NsmNutrientCompositeItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAnalysis", TypeName = "char(40)")]
        public string FkAnalysis { get; set; }
        public double? Weighting { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
    }
}
