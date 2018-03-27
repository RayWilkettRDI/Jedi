using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmTradeMaterialSpecRelation")]
    public partial class GsmTradeMaterialSpecRelation
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTradeSpec", TypeName = "char(40)")]
        public string FkTradeSpec { get; set; }
        [Column("fkMaterialSpec", TypeName = "char(40)")]
        public string FkMaterialSpec { get; set; }
        [Column("fkContext", TypeName = "char(40)")]
        public string FkContext { get; set; }
        [Column("fkMaterialSpecQuantityUOM", TypeName = "char(40)")]
        public string FkMaterialSpecQuantityUom { get; set; }
        public double? MaterialSpecQuantity { get; set; }
        public bool? IsCustomAssociation { get; set; }
        [Column("fkPackSize", TypeName = "char(40)")]
        public string FkPackSize { get; set; }
        public bool? IsCostOverridden { get; set; }
    }
}
