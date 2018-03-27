using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("dwbSpecifications")]
    public partial class DwbSpecifications
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("DWBNumber", TypeName = "char(7)")]
        public string Dwbnumber { get; set; }
        [Column("fkDisplayedLegacyProfile", TypeName = "char(40)")]
        public string FkDisplayedLegacyProfile { get; set; }
        public int? VersionNumber { get; set; }
        [Column("fkCurrency", TypeName = "char(40)")]
        public string FkCurrency { get; set; }
        [StringLength(64)]
        public string OptimizationObjectiveValue1 { get; set; }
        [StringLength(2400)]
        public string Description { get; set; }
        [StringLength(256)]
        public string SnapshotDescription { get; set; }
        [StringLength(64)]
        public string OptimizationObjectiveValue2 { get; set; }
        [Column("fkSpecification", TypeName = "char(40)")]
        public string FkSpecification { get; set; }
        [Column("fkDWBTaxonomyNode", TypeName = "char(40)")]
        public string FkDwbtaxonomyNode { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SnapshotTimestamp { get; set; }
        [Column("DWBIssueNumber", TypeName = "char(3)")]
        public string DwbissueNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastOptimizationDateTime { get; set; }
        [Column("OptimizationObjectiveID", TypeName = "char(8)")]
        public string OptimizationObjectiveId { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [StringLength(75)]
        public string Name { get; set; }
        [Column("fkSpecQuantityUOM", TypeName = "char(40)")]
        public string FkSpecQuantityUom { get; set; }
        [Column(TypeName = "char(2)")]
        public string OptimizationConstraintCohesion { get; set; }
        [Column(TypeName = "char(2)")]
        public string OptimizationReformPolcy { get; set; }
        public double? WaterGainLossFactor { get; set; }
        [Column("fkFinalRelDensityORMassUOM", TypeName = "char(40)")]
        public string FkFinalRelDensityOrmassUom { get; set; }
        [Column("LIOCustomizedStatement")]
        [StringLength(2000)]
        public string LiocustomizedStatement { get; set; }
        public double? ProcessingLossFactor { get; set; }
        [Column("fkFinalRelDensityORVolumeUOM", TypeName = "char(40)")]
        public string FkFinalRelDensityOrvolumeUom { get; set; }
        public double? TotalSolidsOverride { get; set; }
        [Column("FinalRelDensityORVolumeValue")]
        public double? FinalRelDensityOrvolumeValue { get; set; }
        [Column("FinalRelDensityORMassValue")]
        public double? FinalRelDensityOrmassValue { get; set; }
        [Column("fkGSMSaveTarget", TypeName = "char(40)")]
        public string FkGsmsaveTarget { get; set; }
        [Column("fkSCRMSupplierBase", TypeName = "char(40)")]
        public string FkScrmsupplierBase { get; set; }
        [StringLength(12)]
        public string CostType { get; set; }
        [StringLength(75)]
        public string ProjectName { get; set; }
        [Column("fkPSTaxonomyNode", TypeName = "char(40)")]
        public string FkPstaxonomyNode { get; set; }
        [Column("RACCValue")]
        public double? Raccvalue { get; set; }
        [Column("fkLabelClaimsClass", TypeName = "char(40)")]
        public string FkLabelClaimsClass { get; set; }
        [Column("fkRaccUOM", TypeName = "char(40)")]
        public string FkRaccUom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ImportTimestamp { get; set; }
        [Column("fkSnapshotParent", TypeName = "char(40)")]
        public string FkSnapshotParent { get; set; }
        [Column("fkWorkingVersionParent", TypeName = "char(40)")]
        public string FkWorkingVersionParent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SnapshotRestoredTimestamp { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("formulationYield")]
        public double? FormulationYield { get; set; }
    }
}
