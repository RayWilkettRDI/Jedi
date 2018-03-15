using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmNutritionalPanelItem")]
    public partial class GsmNutritionalPanelItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? Optional { get; set; }
        [Column("fkNPItemML", TypeName = "char(40)")]
        public string FkNpitemMl { get; set; }
        public int? Sequence { get; set; }
        [Column("fkNPFormat", TypeName = "char(40)")]
        public string FkNpformat { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
