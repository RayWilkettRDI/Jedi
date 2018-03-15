using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FoodServiceProductAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [Column("fkStandardShelfLifeUOM", TypeName = "char(40)")]
        public string FkStandardShelfLifeUom { get; set; }
        [Column("fkSecondaryShelfLifeUOM", TypeName = "char(40)")]
        public string FkSecondaryShelfLifeUom { get; set; }
        public double? StandardShelfLife { get; set; }
        public double? SecondaryShelfLife { get; set; }
        [Column("fkTertiaryShelfLifeUOM", TypeName = "char(40)")]
        public string FkTertiaryShelfLifeUom { get; set; }
        public double? TertiaryShelfLife { get; set; }
        [Column("fkPrimaryStorage", TypeName = "char(40)")]
        public string FkPrimaryStorage { get; set; }
        [Column("fkSecondaryStorage", TypeName = "char(40)")]
        public string FkSecondaryStorage { get; set; }
        [Column("fkTertiaryStorage", TypeName = "char(40)")]
        public string FkTertiaryStorage { get; set; }
    }
}
