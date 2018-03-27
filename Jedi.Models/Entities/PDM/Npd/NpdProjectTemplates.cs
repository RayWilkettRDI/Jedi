using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdProjectTemplates")]
    public partial class NpdProjectTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsMasterTemplate { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        public bool? RequiresStrategicBrief { get; set; }
        [Column("fkStartStage", TypeName = "char(40)")]
        public string FkStartStage { get; set; }
        [Column("ISPAutoApprove")]
        public bool? IspautoApprove { get; set; }
        [Column("ISPSignatureRequestSLARedDays")]
        public int? IspsignatureRequestSlaredDays { get; set; }
        [Column("ISPSigRequestSLAAmberDays")]
        public int? IspsigRequestSlaamberDays { get; set; }
        [Column("fkMetricCurrency", TypeName = "char(40)")]
        public string FkMetricCurrency { get; set; }
        [Column("fkStageMaster", TypeName = "char(40)")]
        public string FkStageMaster { get; set; }
        [Column("fkSnapshotParent")]
        [StringLength(40)]
        public string FkSnapshotParent { get; set; }
        [StringLength(256)]
        public string SnapshotDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SnapshotTimestamp { get; set; }
        public bool? CanAddRemoveCustomSection { get; set; }
        public bool? CanAddRemoveExtendedAttribute { get; set; }
        [StringLength(20)]
        public string ResolutionStrategy { get; set; }
    }
}
