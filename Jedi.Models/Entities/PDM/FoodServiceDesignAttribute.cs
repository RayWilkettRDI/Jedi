using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FoodServiceDesignAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? VolumeConversion { get; set; }
        [Column("fkVolumeConversionUOM", TypeName = "char(40)")]
        public string FkVolumeConversionUom { get; set; }
        public double? MassConversion { get; set; }
        [Column("fkMassConversionUOM", TypeName = "char(40)")]
        public string FkMassConversionUom { get; set; }
        public double? UnitConversion { get; set; }
        [Column("fkUnitConversionUOM", TypeName = "char(40)")]
        public string FkUnitConversionUom { get; set; }
        public double? TotalSolids { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
