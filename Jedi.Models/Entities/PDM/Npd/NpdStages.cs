using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStages")]
    public partial class NpdStages
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkProject", TypeName = "char(40)")]
        public string FkProject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinishDate { get; set; }
        [Column("fkStartGateUser", TypeName = "char(40)")]
        public string FkStartGateUser { get; set; }
        [Column("fkStartStageUser", TypeName = "char(40)")]
        public string FkStartStageUser { get; set; }
        [Column("fkStageTemplate", TypeName = "char(40)")]
        public string FkStageTemplate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartGateDate { get; set; }
        [Column("fkFinishUser", TypeName = "char(40)")]
        public string FkFinishUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartStageDate { get; set; }
        public int? StageNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlannedStartStageDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlannedStartGateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlannedEndStageDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlannedEndGateDate { get; set; }
    }
}
