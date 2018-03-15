using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TheoreticalSubcomponentAttr
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public int Target { get; set; }
        [Required]
        [Column("fkWeight", TypeName = "char(40)")]
        public string FkWeight { get; set; }
        [Required]
        [Column("fkWeightOverride", TypeName = "char(40)")]
        public string FkWeightOverride { get; set; }
        [StringLength(256)]
        public string Comments { get; set; }
    }
}
