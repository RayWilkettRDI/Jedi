using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqTradeQuestionnaire")]
    public partial class EqTradeQuestionnaire
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkRequest", TypeName = "char(40)")]
        public string FkRequest { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string ShortName { get; set; }
        [StringLength(2400)]
        public string Description { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        [StringLength(256)]
        public string ComplianceFreeText { get; set; }
        [StringLength(256)]
        public string AllergensFreeText { get; set; }
        [StringLength(256)]
        public string IntolerancesFreeText { get; set; }
        [StringLength(256)]
        public string AdditivesFreeText { get; set; }
        [StringLength(1000)]
        public string PackagingAttributeCoding { get; set; }
        public double? ShelfLife { get; set; }
        [Column("fkShelfLifeUOM", TypeName = "char(40)")]
        public string FkShelfLifeUom { get; set; }
        [Column(TypeName = "char(40)")]
        public string ShelfLifeType { get; set; }
        [StringLength(50)]
        public string StorageRequirements { get; set; }
        public double? MinStorageTemp { get; set; }
        [Column("fkMinStorageTempUOM", TypeName = "char(40)")]
        public string FkMinStorageTempUom { get; set; }
        public double? MaxStorageTemp { get; set; }
        [Column("fkMaxStorageTempUOM", TypeName = "char(40)")]
        public string FkMaxStorageTempUom { get; set; }
        [StringLength(2400)]
        public string Comments { get; set; }
        [Column("fkNutrientMeasurementUOM", TypeName = "char(40)")]
        public string FkNutrientMeasurementUom { get; set; }
        [StringLength(50)]
        public string SupplierTradeNumber { get; set; }
        [Column("AdditivesMCFreeText")]
        [StringLength(256)]
        public string AdditivesMcfreeText { get; set; }
        [Column("AllergensMCFreeText")]
        [StringLength(256)]
        public string AllergensMcfreeText { get; set; }
        [Column("IntolerancesMCFreeText")]
        [StringLength(256)]
        public string IntolerancesMcfreeText { get; set; }
    }
}
