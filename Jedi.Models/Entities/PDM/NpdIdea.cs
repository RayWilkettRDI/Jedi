using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdIdea")]
    public partial class NpdIdea
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModificationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OriginationDate { get; set; }
        [Column("fkModifier", TypeName = "char(40)")]
        public string FkModifier { get; set; }
        [Column("fkDisplayCurrency", TypeName = "char(40)")]
        public string FkDisplayCurrency { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        public bool? IsPrivate { get; set; }
        [Column("fkIdeaTemplate", TypeName = "char(40)")]
        public string FkIdeaTemplate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestDate { get; set; }
        [StringLength(64)]
        public string InternalProjectNumber { get; set; }
        [Column("fkConversionTimeFrame", TypeName = "char(40)")]
        public string FkConversionTimeFrame { get; set; }
        [StringLength(1000)]
        public string AdminsCaption { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastWorkflowActionDate { get; set; }
        [Column("fkExecutiveReviewer", TypeName = "char(40)")]
        public string FkExecutiveReviewer { get; set; }
        [Column("fkStrategicBrief", TypeName = "char(40)")]
        public string FkStrategicBrief { get; set; }
        [Column("fkTargetStage", TypeName = "char(40)")]
        public string FkTargetStage { get; set; }
        [Column("fkProjectType", TypeName = "char(40)")]
        public string FkProjectType { get; set; }
        public bool? ProjectPrivate { get; set; }
        [StringLength(256)]
        public string IdeaTitle { get; set; }
        [Column("SignatureRequestSLAAmberDays")]
        public int? SignatureRequestSlaamberDays { get; set; }
        [Column("SignatureRequestSLARedDays")]
        public int? SignatureRequestSlaredDays { get; set; }
    }
}
