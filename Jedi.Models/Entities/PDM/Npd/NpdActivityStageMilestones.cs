using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActivityStageMilestones")]
    public partial class NpdActivityStageMilestones
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkActivityProjectSchedule", TypeName = "char(40)")]
        public string FkActivityProjectSchedule { get; set; }
        public int? StageNumber { get; set; }
        [Column("isGate")]
        public bool? IsGate { get; set; }
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
