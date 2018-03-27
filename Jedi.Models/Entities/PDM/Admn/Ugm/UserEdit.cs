using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Ugm
{
    [Table("userEdit")]
    public partial class UserEdit
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [Column("HasGSMAccess")]
        public bool? HasGsmaccess { get; set; }
        [Column("fkAffiliateID", TypeName = "char(40)")]
        public string FkAffiliateId { get; set; }
        [StringLength(100)]
        public string JobTitle { get; set; }
        [StringLength(50)]
        public string Lastname { get; set; }
        [Column("PreferredUILanguage")]
        public int? PreferredUilanguage { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("HasLMPAccess")]
        public bool? HasLmpaccess { get; set; }
        [Column("HasSCBSAccess")]
        public bool? HasScbsaccess { get; set; }
        [Column("fkAddress", TypeName = "char(40)")]
        public string FkAddress { get; set; }
        [StringLength(44)]
        public string Password { get; set; }
        [Column("HasREGAccess")]
        public bool? HasRegaccess { get; set; }
        public bool? ShowSpecHistory { get; set; }
        [Column("HasEQAccess")]
        public bool? HasEqaccess { get; set; }
        public bool? TreatVisibilityAsAccess { get; set; }
        public bool? HasCssPortalAccess { get; set; }
        [Column("fkSpecBusinessUnit", TypeName = "char(40)")]
        public string FkSpecBusinessUnit { get; set; }
        [Column("GSMTaxonomyTabDefault")]
        public bool? GsmtaxonomyTabDefault { get; set; }
        public bool? HasAdminAccess { get; set; }
        [Column("fkCompanyID", TypeName = "char(40)")]
        public string FkCompanyId { get; set; }
        [Column("ExternalID")]
        [StringLength(50)]
        public string ExternalId { get; set; }
        public bool? HasReportingAccess { get; set; }
        [Column("HasSPAAccess")]
        public bool? HasSpaaccess { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        public bool? HighBandwidth { get; set; }
        public bool? SingleTranslationEditing { get; set; }
        [Column("HasSCRMAccess")]
        public bool? HasScrmaccess { get; set; }
        [Column("HasRAPAccess")]
        public bool? HasRapaccess { get; set; }
        public int? PreferredLanguage { get; set; }
        [Column("email")]
        [StringLength(96)]
        public string Email { get; set; }
        public int? PreferredCulture { get; set; }
        public int? Status { get; set; }
        [Column("HasHLRAccess")]
        public bool? HasHlraccess { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        public bool? HasPrintAccess { get; set; }
        [Column("notespassword")]
        [StringLength(42)]
        public string Notespassword { get; set; }
        [Column("HasDWBAccess")]
        public bool? HasDwbaccess { get; set; }
        [Column("HasNPDAccess")]
        public bool? HasNpdaccess { get; set; }
        [Column("HasPQSAccess")]
        public bool? HasPqsaccess { get; set; }
        [Column("HasWFAAccess")]
        public bool? HasWfaaccess { get; set; }
        [Column("action")]
        [StringLength(10)]
        public string Action { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("requestedDate", TypeName = "datetime")]
        public DateTime? RequestedDate { get; set; }
        [Column("fkRequestingUser", TypeName = "char(40)")]
        public string FkRequestingUser { get; set; }
        [Column("fkWorkflowStatus", TypeName = "char(40)")]
        public string FkWorkflowStatus { get; set; }
        [Column("fkLastStatusChangeUser", TypeName = "char(40)")]
        public string FkLastStatusChangeUser { get; set; }
        [Column("lastStatusChangeDate", TypeName = "datetime")]
        public DateTime? LastStatusChangeDate { get; set; }
        [Column("fkTargetUser", TypeName = "char(40)")]
        public string FkTargetUser { get; set; }
        public bool? ShowHiddenSpecs { get; set; }
        [Column("HasUGMAccess")]
        public bool? HasUgmaccess { get; set; }
        [Column("facilityName")]
        [StringLength(256)]
        public string FacilityName { get; set; }
        [Column("HasDRLAccess")]
        public bool? HasDrlaccess { get; set; }
        [Column("fkWorkflowOwner", TypeName = "char(40)")]
        public string FkWorkflowOwner { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PasswordLastModified { get; set; }
        [Column("fkDefaultUOM", TypeName = "char(40)")]
        public string FkDefaultUom { get; set; }
        [Column("HasPQMAccess")]
        public bool? HasPqmaccess { get; set; }
        [Column("resultsPerPageSearchResults")]
        public int? ResultsPerPageSearchResults { get; set; }
        [Column("resultsPerPageActionItems")]
        public int? ResultsPerPageActionItems { get; set; }
        [StringLength(42)]
        public string Passphrase { get; set; }
        [StringLength(40)]
        public string PassphraseSalt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PassphraseLastModified { get; set; }
        [Column("ESignatureEnabled")]
        public bool? EsignatureEnabled { get; set; }
        public bool? ClearPassphrase { get; set; }
        [StringLength(30)]
        public string PasswordHashAlgorithm { get; set; }
        [StringLength(40)]
        public string PasswordSalt { get; set; }
        [Column("fkPreferredTimeZone", TypeName = "char(40)")]
        public string FkPreferredTimeZone { get; set; }
    }
}
