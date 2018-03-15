using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("spSupplierReps")]
    public partial class SpSupplierReps
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RegistrationDate { get; set; }
        [StringLength(30)]
        public string RepPostalCode { get; set; }
        [StringLength(261)]
        public string RepState { get; set; }
        [StringLength(100)]
        public string CompanyStreet1 { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string RepCity { get; set; }
        [StringLength(100)]
        public string RepTelephone { get; set; }
        [StringLength(30)]
        public string CompanyTelephone { get; set; }
        [StringLength(100)]
        public string RepStreet2 { get; set; }
        [Column("PreferredUILanguage")]
        public int? PreferredUilanguage { get; set; }
        [StringLength(100)]
        public string CompanyStreet2 { get; set; }
        public int? PreferredCulture { get; set; }
        [Column("fkApplicationStatus", TypeName = "char(40)")]
        public string FkApplicationStatus { get; set; }
        [StringLength(44)]
        public string Password { get; set; }
        [Column("fkRepCountry", TypeName = "char(40)")]
        public string FkRepCountry { get; set; }
        [Column("fkCompanyCountry", TypeName = "char(40)")]
        public string FkCompanyCountry { get; set; }
        [StringLength(50)]
        public string RepFax { get; set; }
        public int? Status { get; set; }
        [StringLength(256)]
        public string CompanyWebsite { get; set; }
        [StringLength(100)]
        public string CompanyName { get; set; }
        [StringLength(50)]
        public string CompanyState { get; set; }
        [StringLength(100)]
        public string RepStreet1 { get; set; }
        [StringLength(30)]
        public string CompanyFax { get; set; }
        [StringLength(100)]
        public string Firstname { get; set; }
        [StringLength(100)]
        public string Lastname { get; set; }
        [StringLength(30)]
        public string CompanyPostalCode { get; set; }
        [StringLength(40)]
        public string NotesPassword { get; set; }
        public int? PreferredLanguage { get; set; }
        [StringLength(50)]
        public string CompanyCity { get; set; }
        public bool? CanSeeContacts { get; set; }
        public bool? HasResetPassword { get; set; }
        [StringLength(30)]
        public string PasswordHashAlgorithm { get; set; }
        [StringLength(40)]
        public string PasswordSalt { get; set; }
        [StringLength(42)]
        public string Passphrase { get; set; }
        [Column("ESignatureEnabled")]
        public bool? EsignatureEnabled { get; set; }
        public bool? ClearPassphrase { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PassphraseLastModified { get; set; }
        [StringLength(40)]
        public string PassphraseSalt { get; set; }
        [Column("HasSupplierPQMAccess")]
        public bool? HasSupplierPqmaccess { get; set; }
        [Column("resultsPerPageActionItems")]
        public int? ResultsPerPageActionItems { get; set; }
        [Column("resultsPerPageSearchResults")]
        public int? ResultsPerPageSearchResults { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PasswordLastModified { get; set; }
        [StringLength(100)]
        public string JobTitle { get; set; }
        [StringLength(50)]
        public string CellPage { get; set; }
        public bool? EmergencyContact { get; set; }
        [StringLength(50)]
        public string EmergencyContactNumber { get; set; }
        [StringLength(600)]
        public string Description { get; set; }
        public bool? HasContactsAccess { get; set; }
        [Column("HasDRLAccess")]
        public bool? HasDrlaccess { get; set; }
        [Column("HasGSMAccess")]
        public bool? HasGsmaccess { get; set; }
        public bool? HasManagerAccess { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastVerificationDate { get; set; }
        [StringLength(100)]
        public string VerificationTimeToken { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }
        public bool? IsSelfRegistration { get; set; }
        [Column("fkAuthor")]
        [StringLength(40)]
        public string FkAuthor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column("HasEQAccess")]
        public bool? HasEqaccess { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastRequestDate { get; set; }
        public bool? Archived { get; set; }
        [Column("ExternalID")]
        [StringLength(50)]
        public string ExternalId { get; set; }
    }
}
