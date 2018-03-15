using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FoodServiceMenuItemBuild
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? Quantity { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [Column("fkQuantityUOM", TypeName = "char(40)")]
        public string FkQuantityUom { get; set; }
        [StringLength(2048)]
        public string Comments { get; set; }
        [Column("fkRelatedSpec", TypeName = "char(40)")]
        public string FkRelatedSpec { get; set; }
        public int? Sequence { get; set; }
        public bool IsCustomAssociation { get; set; }
    }
}
