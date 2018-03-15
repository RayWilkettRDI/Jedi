using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbPackageConfigDO")]
    public partial class DwbPackageConfigDo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? ServingSize { get; set; }
        public double? Servings { get; set; }
        public int? Quantity { get; set; }
        [Column("fkDWBSpec", TypeName = "char(40)")]
        public string FkDwbspec { get; set; }
        [Column("fkNetWeightUOM", TypeName = "char(40)")]
        public string FkNetWeightUom { get; set; }
        [Column("fkServingSizeUOM", TypeName = "char(40)")]
        public string FkServingSizeUom { get; set; }
        public double? ContainerNetWeight { get; set; }
        [Column("fkReferenceAmtUOM", TypeName = "char(40)")]
        public string FkReferenceAmtUom { get; set; }
        [Column("fkLabelClaimsClass", TypeName = "char(40)")]
        public string FkLabelClaimsClass { get; set; }
        public double? ReferenceAmt { get; set; }
        public double? TareWeight { get; set; }
        [Column("fkTareWeightUOM", TypeName = "char(40)")]
        public string FkTareWeightUom { get; set; }
        [Column("fkLabelClaimsNutSourceType", TypeName = "char(40)")]
        public string FkLabelClaimsNutSourceType { get; set; }
    }
}
