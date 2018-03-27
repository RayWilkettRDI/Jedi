using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActivityTemplateSteps")]
    public partial class NpdActivityTemplateSteps
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? FinancialReaders { get; set; }
        [Column("SLAAmber")]
        public int? Slaamber { get; set; }
        public int? StepNumber { get; set; }
        [Column("SLARed")]
        public int? Slared { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public bool? TeamMemberReaders { get; set; }
        public bool? GatekeeperReaders { get; set; }
        public bool? TeamLeaderReaders { get; set; }
        [Column("AllNPDReaders")]
        public bool? AllNpdreaders { get; set; }
        public bool? OriginatorOwner { get; set; }
        public bool? IsTerminalStep { get; set; }
        public bool? AddNotifyReaders { get; set; }
        public bool? AutoApprove { get; set; }
        public bool? IsSuccessfulCompletion { get; set; }
        public bool? RespectParentActivity { get; set; }
        [Column("fkPlmUserGroupContainer", TypeName = "char(40)")]
        public string FkPlmUserGroupContainer { get; set; }
        [Column("fkActivityReadersOnProject", TypeName = "char(40)")]
        public string FkActivityReadersOnProject { get; set; }
        [Column("fkMasterStep", TypeName = "char(40)")]
        public string FkMasterStep { get; set; }
        [StringLength(20)]
        public string AddedNotifyResolutionStrategy { get; set; }
        [StringLength(20)]
        public string OwnerResolutionStrategy { get; set; }
        [StringLength(20)]
        public string SigReqResolutionStrategy { get; set; }
    }
}
