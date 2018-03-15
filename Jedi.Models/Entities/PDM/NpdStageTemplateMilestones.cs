using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdStageTemplateMilestones")]
    public partial class NpdStageTemplateMilestones
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("isGate")]
        public bool? IsGate { get; set; }
        public int? SortOrder { get; set; }
        [Column("plannedStartDateOffset")]
        public int? PlannedStartDateOffset { get; set; }
        [Column("plannedEndDateOffset")]
        public int? PlannedEndDateOffset { get; set; }
        [Column("fkStageTemplate", TypeName = "char(40)")]
        public string FkStageTemplate { get; set; }
        [Required]
        [Column("fkProjectMilestoneDefaults", TypeName = "char(40)")]
        public string FkProjectMilestoneDefaults { get; set; }
    }
}
