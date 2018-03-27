using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmSourcingApproval")]
    public partial class ScrmSourcingApproval
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("vendoringredientnumber")]
        [StringLength(50)]
        public string Vendoringredientnumber { get; set; }
        [Column("fkFacilityID", TypeName = "char(40)")]
        public string FkFacilityId { get; set; }
        [Column("fksourcingtype", TypeName = "char(40)")]
        public string Fksourcingtype { get; set; }
        [StringLength(50)]
        public string FactoryNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        [Column("fkTestingProtocolSelection", TypeName = "char(40)")]
        public string FkTestingProtocolSelection { get; set; }
        [Column("fkspecID", TypeName = "char(40)")]
        public string FkspecId { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("fksourcingstatus", TypeName = "char(40)")]
        public string Fksourcingstatus { get; set; }
        public int? Class { get; set; }
        public bool? VendorHasApproved { get; set; }
        public int? ActiveSigDocGroupSequence { get; set; }
        [Column("RedSLA")]
        public int? RedSla { get; set; }
        [Column("AmberSLA")]
        public int? AmberSla { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkflowStartDate { get; set; }
        [Column("fkProcessTemplate")]
        [StringLength(40)]
        public string FkProcessTemplate { get; set; }
        [StringLength(100)]
        public string SupplierSignature { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SignatureDate { get; set; }
        [Column("fkSourcingApprovalClass", TypeName = "char(40)")]
        public string FkSourcingApprovalClass { get; set; }
        [Column("fkPermissionTemplate", TypeName = "char(40)")]
        public string FkPermissionTemplate { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
        [Column(TypeName = "char(7)")]
        public string Num { get; set; }
        public bool? IsTemplate { get; set; }
        [Column("fkOriginatingTemplate", TypeName = "char(40)")]
        public string FkOriginatingTemplate { get; set; }
        public bool? Archived { get; set; }
        public bool? IsHidden { get; set; }
    }
}
