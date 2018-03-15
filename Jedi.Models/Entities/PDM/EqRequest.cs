using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqRequest")]
    public partial class EqRequest
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(100)]
        public string InternalCompanyName { get; set; }
        [StringLength(261)]
        public string InternalStateProvince { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(30)]
        public string InternalFax { get; set; }
        [StringLength(256)]
        public string InternalEmail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDueDate { get; set; }
        [StringLength(30)]
        public string SupplierPostalCode { get; set; }
        [StringLength(50)]
        public string SupplierCity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RcvdDate { get; set; }
        [StringLength(261)]
        public string SupplierStateProvince { get; set; }
        [StringLength(100)]
        public string InternalStreet2 { get; set; }
        [StringLength(100)]
        public string SupplierStreet1 { get; set; }
        [StringLength(100)]
        public string SupplierFname { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [StringLength(30)]
        public string InternalPostalCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SentDate { get; set; }
        [StringLength(100)]
        public string SupplierCompany { get; set; }
        [Column("fkEQModel", TypeName = "char(40)")]
        public string FkEqmodel { get; set; }
        [StringLength(50)]
        public string InternalCountryName { get; set; }
        [StringLength(100)]
        public string InternalStreet1 { get; set; }
        [StringLength(30)]
        public string InternalPhone { get; set; }
        [StringLength(100)]
        public string SupplierLname { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column(TypeName = "nchar(7)")]
        public string ReqNumber { get; set; }
        [Column("fkSupplier", TypeName = "char(40)")]
        public string FkSupplier { get; set; }
        [StringLength(100)]
        public string SupplierPhone { get; set; }
        [StringLength(100)]
        public string SupplierStreet2 { get; set; }
        [StringLength(50)]
        public string SupplierCountryName { get; set; }
        [StringLength(50)]
        public string InternalCity { get; set; }
        [StringLength(256)]
        public string SupplierEmail { get; set; }
        [Column("SupplierSCRMNumber")]
        [StringLength(7)]
        public string SupplierScrmnumber { get; set; }
        [StringLength(50)]
        public string SupplierFax { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(1024)]
        public string Comments { get; set; }
        [Column(TypeName = "char(6)")]
        public string StatusCode { get; set; }
        [Column("ImportedIntoGSMCode", TypeName = "char(6)")]
        public string ImportedIntoGsmcode { get; set; }
        [Column("fkImportSpec", TypeName = "char(40)")]
        public string FkImportSpec { get; set; }
        [Column("fkSelectedBreakdowns", TypeName = "char(40)")]
        public string FkSelectedBreakdowns { get; set; }
        [Column("fkPrimaryOwner", TypeName = "char(40)")]
        public string FkPrimaryOwner { get; set; }
        [StringLength(50)]
        public string InternalLname { get; set; }
        [StringLength(50)]
        public string InternalFname { get; set; }
        [Column("securityAccessLevel")]
        public int? SecurityAccessLevel { get; set; }
        [Column(TypeName = "nchar(7)")]
        public string AffiliatedSpecNum { get; set; }
        public int? IsSupplierInitiated { get; set; }
        [Column("fkSourcingApproval", TypeName = "char(40)")]
        public string FkSourcingApproval { get; set; }
        public int? SecondarySecurityAccessLevel { get; set; }
        public bool? IsReturnToSupplier { get; set; }
        [Column("fkSupplierContact", TypeName = "char(40)")]
        public string FkSupplierContact { get; set; }
        [Column("fkCompanyOrFacility", TypeName = "char(40)")]
        public string FkCompanyOrFacility { get; set; }
    }
}
