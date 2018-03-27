using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmStageGateWorkflowStatuses")]
    public partial class PlmStageGateWorkflowStatuses
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("applicationName", TypeName = "char(75)")]
        public string ApplicationName { get; set; }
        [Column("subStageNumber")]
        public int? SubStageNumber { get; set; }
        [Column("fkCommonWorkflowStatus", TypeName = "char(40)")]
        public string FkCommonWorkflowStatus { get; set; }
        [Column("stageNumber")]
        public int? StageNumber { get; set; }
    }
}
