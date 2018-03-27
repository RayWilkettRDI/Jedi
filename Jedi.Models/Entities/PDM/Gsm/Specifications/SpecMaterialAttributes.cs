using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specMaterialAttributes")]
    public partial class SpecMaterialAttributes
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkIngredientSpec", TypeName = "char(40)")]
        public string FkIngredientSpec { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [StringLength(50)]
        public string ShelfLife { get; set; }
        [Column("ShelfLifeUOM")]
        public int? ShelfLifeUom { get; set; }
        [StringLength(50)]
        public string InternalShelfLife { get; set; }
        [Column("InternalShelfLifeUOM")]
        public int? InternalShelfLifeUom { get; set; }
        [Column(TypeName = "text")]
        public string StorageInstructions { get; set; }
        public double? Density1 { get; set; }
        [Column("UOM1")]
        [StringLength(50)]
        public string Uom1 { get; set; }
        public double? Density2 { get; set; }
        [Column("UOM2")]
        [StringLength(50)]
        public string Uom2 { get; set; }
        [Column("UOM3")]
        [StringLength(50)]
        public string Uom3 { get; set; }
        [Column("fkVolumeUOM", TypeName = "char(40)")]
        public string FkVolumeUom { get; set; }
        public double? VolumeDensity { get; set; }
        public double? MassDensity { get; set; }
        [Column("fkMassUOM", TypeName = "char(40)")]
        public string FkMassUom { get; set; }
        public double? TotalSolids { get; set; }
        public double? UnitConversion { get; set; }
        [Column("fkUnitConversionUOM", TypeName = "char(40)")]
        public string FkUnitConversionUom { get; set; }
        [Column("ediblePortion")]
        public double EdiblePortion { get; set; }
    }
}
