using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Formulation
{
    [Table("gsmFormulationInputs")]
    public partial class GsmFormulationInputs
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkInputUOM", TypeName = "char(40)")]
        public string FkInputUom { get; set; }
        public double? GainLossFactor { get; set; }
        public double? InputQuantityValue { get; set; }
        [Column("fkMaterial", TypeName = "char(40)")]
        public string FkMaterial { get; set; }
        [Column("fkFormulationStep", TypeName = "char(40)")]
        public string FkFormulationStep { get; set; }
        public int? Sequence { get; set; }
        public double? PercentStepFactor { get; set; }
        [Column("fkContext", TypeName = "char(40)")]
        public string FkContext { get; set; }
        [StringLength(500)]
        public string Annotation { get; set; }
        public bool? IsCostFromCostLibrary { get; set; }
        public int? MaterialType { get; set; }
        [Column("fkPackagingLevel", TypeName = "char(40)")]
        public string FkPackagingLevel { get; set; }
        public double? InputYieldValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AllergensKnownToContainRefresh { get; set; }
        [Column("fkBasis", TypeName = "char(40)")]
        public string FkBasis { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IntolerancesDoesNotContainRefr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompliesWithRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AllergensDoesNotContainRefresh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdditivesMayContainRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CombinedIngredientRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExtendedAttributeRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BreakdownRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NutrientRefreshDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IntolerancesKnownToContainRefr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IntolerancesMayContainRefreshD { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdditivesKnownToContainRefresh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdditivesDoesNotContainRefresh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IngredientAttributesRefreshDat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AllergensMayContainRefreshDate { get; set; }
        public bool? IsCustomAssociation { get; set; }
        [Column("percentBatchFactor")]
        public double? PercentBatchFactor { get; set; }
        public double? InputYieldMin { get; set; }
        public double? InputYieldMax { get; set; }
        public double? InputQuantityMin { get; set; }
        public double? InputQuantityMax { get; set; }
        public double? InputPercentMin { get; set; }
        public double? InputPercentMax { get; set; }
        [Column("fkPackSzie", TypeName = "char(40)")]
        public string FkPackSzie { get; set; }
    }
}
