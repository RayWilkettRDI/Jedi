using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActProjSchedCustMilestones")]
    public partial class NpdActProjSchedCustMilestones
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkProjectSchedule", TypeName = "char(40)")]
        public string FkProjectSchedule { get; set; }
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlannedStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlannedEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualEndDate { get; set; }
    }
}
