using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Nsm
{
    public partial class NutrientOptObjectives
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkNutrientItem", TypeName = "char(40)")]
        public string FkNutrientItem { get; set; }
        public int? ObjectiveType { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
        public int? HandlingUnit { get; set; }
    }
}
