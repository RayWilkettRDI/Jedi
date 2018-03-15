using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqMaterialQuestionnaire")]
    public partial class EqMaterialQuestionnaire
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        public double? ShelfLife { get; set; }
        [StringLength(50)]
        public string ShippingRequirements { get; set; }
        [Column("fkRequest", TypeName = "char(40)")]
        public string FkRequest { get; set; }
        [StringLength(2400)]
        public string Description { get; set; }
        [Column("RDMassValue")]
        public double? RdmassValue { get; set; }
        [Column("fkRDVolumeUOM", TypeName = "char(40)")]
        public string FkRdvolumeUom { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(50)]
        public string SupplierIngNumber { get; set; }
        [StringLength(50)]
        public string StorageRequirements { get; set; }
        [StringLength(2048)]
        public string StorageInstructions { get; set; }
        [Column("RDVolumeValue")]
        public double? RdvolumeValue { get; set; }
        [StringLength(4000)]
        public string IngredientStatement { get; set; }
        [StringLength(2048)]
        public string ShippingInstructions { get; set; }
        [Column("fkRDMassUOM", TypeName = "char(40)")]
        public string FkRdmassUom { get; set; }
        [StringLength(100)]
        public string RelativeHumidity { get; set; }
        [StringLength(256)]
        public string AllergensFreeText { get; set; }
        [Column("ShelfLifeUOM")]
        public int? ShelfLifeUom { get; set; }
        [StringLength(256)]
        public string IntolerancesFreeText { get; set; }
        [StringLength(256)]
        public string AdditivesFreeText { get; set; }
        [StringLength(256)]
        public string ComplianceFreeText { get; set; }
        [Column(TypeName = "char(40)")]
        public string ShelfLifeType { get; set; }
        [Column("ediblePortion")]
        public double? EdiblePortion { get; set; }
        [StringLength(2400)]
        public string Comments { get; set; }
        public double? TotalSolids { get; set; }
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
