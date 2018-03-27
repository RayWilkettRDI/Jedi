using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Formulation
{
    [Table("gsmFormulationOutput")]
    public partial class GsmFormulationOutput
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFormulationStep", TypeName = "char(40)")]
        public string FkFormulationStep { get; set; }
        public double? PercentStepFactor { get; set; }
        [Column("fkReferencedMaterial", TypeName = "char(40)")]
        public string FkReferencedMaterial { get; set; }
        public bool? InputsDrivesOutputYield { get; set; }
        public bool? AlwaysRefreshBreakdowns { get; set; }
        public int? LastSavedAccessLevel { get; set; }
        public bool IsCustomAssociation { get; set; }
        [Column("fkTheoreticalCost", TypeName = "char(40)")]
        public string FkTheoreticalCost { get; set; }
    }
}
