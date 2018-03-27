using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.FinishedProduct
{
    public partial class FinishedPackagingSpec
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("hasStorageRequirements")]
        public bool? HasStorageRequirements { get; set; }
        [Column("hasBarcode")]
        public bool? HasBarcode { get; set; }
        [Column("hasReturnable")]
        public bool? HasReturnable { get; set; }
        [Column("hasGTINUPC")]
        public bool? HasGtinupc { get; set; }
        [Column("hasManufacturingCode")]
        public bool? HasManufacturingCode { get; set; }
        [Column("hasRecyclable")]
        public bool? HasRecyclable { get; set; }
        [Column("hasProductClaims")]
        public bool? HasProductClaims { get; set; }
        [Column("hasIngredientStatement")]
        public bool? HasIngredientStatement { get; set; }
        [Column("hasNutritionalPanel")]
        public bool? HasNutritionalPanel { get; set; }
        [Column("hasBrandTrademark")]
        public bool? HasBrandTrademark { get; set; }
        [Column("hasShelfLife")]
        public bool? HasShelfLife { get; set; }
        [Column("lasteditdate", TypeName = "char(10)")]
        public string Lasteditdate { get; set; }
        [Column("hasPreparationInstructions")]
        public bool? HasPreparationInstructions { get; set; }
        [Column("fkBrand", TypeName = "char(40)")]
        public string FkBrand { get; set; }
        [Column("hasNetWeight")]
        public bool? HasNetWeight { get; set; }
        [Column("hasSalesPrice")]
        public bool? HasSalesPrice { get; set; }
        [Column("hasMadeInMadeBy")]
        public bool? HasMadeInMadeBy { get; set; }
        [Column("hasFragile")]
        public bool? HasFragile { get; set; }
        [Column("hasThisWayUp")]
        public bool? HasThisWayUp { get; set; }
    }
}
