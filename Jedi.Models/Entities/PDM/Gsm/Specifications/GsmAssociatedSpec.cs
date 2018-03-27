using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("gsmAssociatedSpec")]
    public partial class GsmAssociatedSpec
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAssociation", TypeName = "char(40)")]
        public string FkAssociation { get; set; }
        [Column("fkTarget", TypeName = "char(40)")]
        public string FkTarget { get; set; }
        [Column("fkHost", TypeName = "char(40)")]
        public string FkHost { get; set; }
        [StringLength(256)]
        public string Comments { get; set; }
        [Column("fkQuantityUOM", TypeName = "char(40)")]
        public string FkQuantityUom { get; set; }
        public double? Quantity { get; set; }
        [Column("fkQuantityRelatedLookup", TypeName = "char(40)")]
        public string FkQuantityRelatedLookup { get; set; }
        public bool IsCustomAssociation { get; set; }
    }
}
