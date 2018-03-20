using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmFormulationSteps")]
    public partial class GsmFormulationSteps
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? StepNumber { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkStepCalcMethodLookup", TypeName = "char(40)")]
        public string FkStepCalcMethodLookup { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public int? Sequence { get; set; }
        public bool? IsConsumerPrepStep { get; set; }
        [StringLength(256)]
        public string StepName { get; set; }
        public double? PackagingInputTotal { get; set; }
        public double? IngredientInputTotal { get; set; }
        [Column("fkStepBehaviorID", TypeName = "char(40)")]
        public string FkStepBehaviorId { get; set; }
    }
}
