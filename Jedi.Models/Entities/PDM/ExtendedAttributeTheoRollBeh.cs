using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ExtendedAttributeTheoRollBeh
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkEAType", TypeName = "char(40)")]
        public string FkEatype { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkBehavior", TypeName = "char(40)")]
        public string FkBehavior { get; set; }
    }
}
