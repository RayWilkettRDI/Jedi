using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmSourcingApprovalNonSpec")]
    public partial class ScrmSourcingApprovalNonSpec
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("fkFacilityID", TypeName = "char(40)")]
        public string FkFacilityId { get; set; }
        [Column("fkSourcingType", TypeName = "char(40)")]
        public string FkSourcingType { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        public int? Class { get; set; }
        public int? ActiveSigDocGroupSequence { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkflowStartDate { get; set; }
        [Column("RedSLA")]
        public int? RedSla { get; set; }
        [Column("AmberSLA")]
        public int? AmberSla { get; set; }
        [Column("fkProcessTemplate")]
        [StringLength(40)]
        public string FkProcessTemplate { get; set; }
        [Column("fkPermissionTemplate", TypeName = "char(40)")]
        public string FkPermissionTemplate { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
        [Column("fkSourcingApprovalClass", TypeName = "char(40)")]
        public string FkSourcingApprovalClass { get; set; }
        [Column(TypeName = "char(7)")]
        public string Num { get; set; }
        public bool? IsTemplate { get; set; }
        [Column("fkOriginatingTemplate", TypeName = "char(40)")]
        public string FkOriginatingTemplate { get; set; }
        public bool? Archived { get; set; }
        public bool? IsHidden { get; set; }
    }
}
