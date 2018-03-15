using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmShelfLives")]
    public partial class GsmShelfLives
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? InternalShelfLifeValue { get; set; }
        [Column("fkInternalShelfLifeUOM", TypeName = "char(40)")]
        public string FkInternalShelfLifeUom { get; set; }
        public double? SuppliersShelfLifeValue { get; set; }
        public double? MinimumDaysRemainingValue { get; set; }
        [Column("fkSuppliersShelfLifeUOM", TypeName = "char(40)")]
        public string FkSuppliersShelfLifeUom { get; set; }
        [Column("fkMinimumDaysRemainingUOM", TypeName = "char(40)")]
        public string FkMinimumDaysRemainingUom { get; set; }
        [Column("fkShelfLifeType", TypeName = "char(40)")]
        public string FkShelfLifeType { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
