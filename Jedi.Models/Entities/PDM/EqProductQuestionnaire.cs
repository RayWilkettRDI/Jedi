using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqProductQuestionnaire")]
    public partial class EqProductQuestionnaire
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkShelfLifeUOM", TypeName = "char(40)")]
        public string FkShelfLifeUom { get; set; }
        [Column("fkRDVolumeUOM", TypeName = "char(40)")]
        public string FkRdvolumeUom { get; set; }
        [Column("fkRDMassUOM", TypeName = "char(40)")]
        public string FkRdmassUom { get; set; }
        [Column("fkRequest", TypeName = "char(40)")]
        public string FkRequest { get; set; }
        public double? ShelfLife { get; set; }
        [Column("RDMassValue")]
        public double? RdmassValue { get; set; }
        [StringLength(4000)]
        public string IngredientStatement { get; set; }
        [StringLength(256)]
        public string IntolerancesFreeText { get; set; }
        [StringLength(256)]
        public string ComplianceFreeText { get; set; }
        [StringLength(256)]
        public string AllergensFreeText { get; set; }
        [StringLength(2048)]
        public string StorageInstructions { get; set; }
        [StringLength(256)]
        public string AdditivesFreeText { get; set; }
        [StringLength(2048)]
        public string ShippingInstructions { get; set; }
        [StringLength(50)]
        public string SupplierProductNumber { get; set; }
        [Column("RDVolumeValue")]
        public double? RdvolumeValue { get; set; }
        [StringLength(2400)]
        public string Description { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        public double? TertiaryShelfLife { get; set; }
        [Column("fkTertiaryShelfLifeUOM", TypeName = "char(40)")]
        public string FkTertiaryShelfLifeUom { get; set; }
        [Column("fkSecondaryShelfLifeUOM", TypeName = "char(40)")]
        public string FkSecondaryShelfLifeUom { get; set; }
        public double? SecondaryShelfLife { get; set; }
        [Column("fkTertiaryStorage", TypeName = "char(40)")]
        public string FkTertiaryStorage { get; set; }
        [Column("fkPrimaryStorage", TypeName = "char(40)")]
        public string FkPrimaryStorage { get; set; }
        [Column("fkSecondaryStorage", TypeName = "char(40)")]
        public string FkSecondaryStorage { get; set; }
        [StringLength(2400)]
        public string Comments { get; set; }
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
