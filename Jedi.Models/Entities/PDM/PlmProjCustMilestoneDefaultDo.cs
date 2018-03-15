using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmProjCustMilestoneDefaultDO")]
    public partial class PlmProjCustMilestoneDefaultDo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkProjectMilestoneDefaults", TypeName = "char(40)")]
        public string FkProjectMilestoneDefaults { get; set; }
        public int? SortOrder { get; set; }
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
        [Column("plannedStartDateOffset")]
        public int? PlannedStartDateOffset { get; set; }
        [Column("plannedEndDateOffset")]
        public int? PlannedEndDateOffset { get; set; }
    }
}
