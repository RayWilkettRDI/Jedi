using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("dwbFormulationItems")]
    public partial class DwbFormulationItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NutrientInfoRefreshDate { get; set; }
        [Column(TypeName = "char(7)")]
        public string SpecNumber { get; set; }
        [Column("fkQuantityUOM", TypeName = "char(40)")]
        public string FkQuantityUom { get; set; }
        [Column("fkBasis", TypeName = "char(40)")]
        public string FkBasis { get; set; }
        public double? Quantity { get; set; }
        [Column("fkSpecStatus", TypeName = "char(50)")]
        public string FkSpecStatus { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MoistureDensityRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CombinedIngredientRefreshDate { get; set; }
        [Column("fkExperiment", TypeName = "char(40)")]
        public string FkExperiment { get; set; }
        [Column(TypeName = "char(1)")]
        public string OptimizationHint { get; set; }
        [Column("fkProfileTaxonomyNode", TypeName = "char(40)")]
        public string FkProfileTaxonomyNode { get; set; }
        public double? GainLossFactor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScalabilityFactorsRefreshDate { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column(TypeName = "char(3)")]
        public string SpecIssueNumber { get; set; }
        [Column("fkRelativeDensityUOM", TypeName = "char(40)")]
        public string FkRelativeDensityUom { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BreakdownRefreshDate { get; set; }
        public double? LastOptimizationChange { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ComplianceInfoRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StdNutrientInfoRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomNutrientInfoRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CostLibraryCostsRefreshDate { get; set; }
        [Column("fkCostLibraryCostUOM", TypeName = "char(40)")]
        public string FkCostLibraryCostUom { get; set; }
        [Column("fkCostLibraryCostCurrency", TypeName = "char(40)")]
        public string FkCostLibraryCostCurrency { get; set; }
        public double? CostLibraryCostAmount { get; set; }
        public int? MaxCostLibrarySequenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdjCostRefreshDate { get; set; }
        public double? CostLibraryCostCost { get; set; }
        public double? DerivedFactor { get; set; }
        [StringLength(150)]
        public string DerivedProductName { get; set; }
        public bool? IsDerivative { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExtAttributeInfoRefreshDate { get; set; }
        public int? Sequence { get; set; }
        [StringLength(100)]
        public string Annotation { get; set; }
    }
}
