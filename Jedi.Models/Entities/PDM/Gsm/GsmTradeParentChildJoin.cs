using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmTradeParentChildJoin")]
    public partial class GsmTradeParentChildJoin
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParentSpec", TypeName = "char(40)")]
        public string FkParentSpec { get; set; }
        [Column("fkChildSpec", TypeName = "char(40)")]
        public string FkChildSpec { get; set; }
        public int? Quantity { get; set; }
        public int? Sequence { get; set; }
        public bool IsCustomAssociation { get; set; }
        public bool? IsCostOverridden { get; set; }
    }
}
