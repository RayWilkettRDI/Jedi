using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbPackagingMaterial")]
    public partial class DwbPackagingMaterial
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? CostLibraryCostAmount { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkAdjCostCurrency", TypeName = "char(40)")]
        public string FkAdjCostCurrency { get; set; }
        public double? Units { get; set; }
        public double? ScrapFactor { get; set; }
        [Column("fkPackagingLevel", TypeName = "char(40)")]
        public string FkPackagingLevel { get; set; }
        [Column("fkPackagingMaterial", TypeName = "char(40)")]
        public string FkPackagingMaterial { get; set; }
        [Column("fkCostLibraryCostCurrency", TypeName = "char(40)")]
        public string FkCostLibraryCostCurrency { get; set; }
        [Column("fkCostLibraryCostUOM", TypeName = "char(40)")]
        public string FkCostLibraryCostUom { get; set; }
        [Column("fkAdjCostUOM", TypeName = "char(40)")]
        public string FkAdjCostUom { get; set; }
        [Column("fkUOMCategory", TypeName = "char(40)")]
        public string FkUomcategory { get; set; }
        public double? AdjCostCost { get; set; }
        public double? AdjCostAmount { get; set; }
        public double? CostLibraryCostCost { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
