using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdProjects")]
    public partial class NpdProjects
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("subStageNumber")]
        public int? SubStageNumber { get; set; }
        [StringLength(64)]
        public string InternalProjectNumber { get; set; }
        [Column("fkProjectTemplate", TypeName = "char(40)")]
        public string FkProjectTemplate { get; set; }
        [Column("fkProjectType", TypeName = "char(40)")]
        public string FkProjectType { get; set; }
        [Column("fkModifier", TypeName = "char(40)")]
        public string FkModifier { get; set; }
        [Column(TypeName = "char(7)")]
        public string ProjectNumber { get; set; }
        [StringLength(1000)]
        public string TeamLeadersCaption { get; set; }
        public int? RequiredActivitiesCount { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column("fkStrategicBrief", TypeName = "char(40)")]
        public string FkStrategicBrief { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModificationDate { get; set; }
        public int? CurrentStageTmpltAmberDays { get; set; }
        [Column("stageNumber")]
        public int? StageNumber { get; set; }
        public int? CurrentStageTmpltRedDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OriginationDate { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("fkCurrentSchedule", TypeName = "char(40)")]
        public string FkCurrentSchedule { get; set; }
        public int? ReqdActivitiesCompleteCount { get; set; }
        [Column("RequiredActivitiesSLA", TypeName = "char(1)")]
        public string RequiredActivitiesSla { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InMarketLaunchDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PackagingApprovedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Stage3BeginsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Stage4BeginsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Stage5BeginsDate { get; set; }
        public int? TimeInDevelopment { get; set; }
        public bool? OnHold { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        public bool? Private { get; set; }
        [Column("fkConsumerValuePerception", TypeName = "char(40)")]
        public string FkConsumerValuePerception { get; set; }
        [Column("fkEnablingTech", TypeName = "char(40)")]
        public string FkEnablingTech { get; set; }
        [Column("fkProjectOwner", TypeName = "char(40)")]
        public string FkProjectOwner { get; set; }
        [Column("fkDisplayCurrency", TypeName = "char(40)")]
        public string FkDisplayCurrency { get; set; }
        [Column("fkConversionTimeFrame", TypeName = "char(40)")]
        public string FkConversionTimeFrame { get; set; }
        [Column("fkIdea", TypeName = "char(40)")]
        public string FkIdea { get; set; }
        [Column("fkPriority", TypeName = "char(40)")]
        public string FkPriority { get; set; }
        [Column("fkRisk", TypeName = "char(40)")]
        public string FkRisk { get; set; }
    }
}
