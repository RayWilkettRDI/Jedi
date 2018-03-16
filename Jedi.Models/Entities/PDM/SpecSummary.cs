using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specSummary")]
    public partial class SpecSummary
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("SpecID", TypeName = "char(40)")]
        public string SpecId { get; set; }
        [Required]
        [Column(TypeName = "nchar(7)")]
        public string SpecNum { get; set; }
        [Required]
        [Column(TypeName = "nchar(10)")]
        public string IssueNum { get; set; }
        public int SpecType { get; set; }
        [Column("SpecStatusID")]
        [StringLength(50)]
        public string SpecStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InactiveDate { get; set; }
        [StringLength(100)]
        public string Supercedes { get; set; }
        [Column("OriginatorID")]
        public int? OriginatorId { get; set; }
        [Column("OrigLangID")]
        public int? OrigLangId { get; set; }
        [Column("theOriginator", TypeName = "char(40)")]
        public string TheOriginator { get; set; }
        [Column(TypeName = "char(11)")]
        public string SpecNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(105)]
        public string OriginatorNameHistorical { get; set; }
        [Column("fkAffiliate", TypeName = "char(40)")]
        public string FkAffiliate { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        [Column("langCreatedIn")]
        public int LangCreatedIn { get; set; }
        [Column("fkSpecBusinessUnit", TypeName = "char(40)")]
        public string FkSpecBusinessUnit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEdit { get; set; }
        [Column("fkGlobalSuccessionSpec", TypeName = "char(40)")]
        public string FkGlobalSuccessionSpec { get; set; }
        public int? GlobalSuccessionState { get; set; }
        [Column("fkPermissionTemplate", TypeName = "char(40)")]
        public string FkPermissionTemplate { get; set; }
        [Column("RedSLA")]
        public int? RedSla { get; set; }
        [Column("fkProcessTemplate", TypeName = "char(40)")]
        public string FkProcessTemplate { get; set; }
        public int? ActiveSigDocGroupSequence { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkflowStartDate { get; set; }
        [Column("AmberSLA")]
        public int? AmberSla { get; set; }
        [Column("fkTaxonomyNode", TypeName = "char(40)")]
        public string FkTaxonomyNode { get; set; }
        public bool? IsHidden { get; set; }
        [Column("securityAccessLevel")]
        public int? SecurityAccessLevel { get; set; }
        public bool? IsTemplate { get; set; }
        [Column("fkOriginatingTemplate", TypeName = "char(40)")]
        public string FkOriginatingTemplate { get; set; }
        public SpecSummaryName SpecSummaryName { get; set; }
        [ForeignKey("SpecStatusId,LangCreatedIn")]
        public CommonWorkflowStatus CommonWorkflowStatus { get; set; }
    }
}
