using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("theoreticalCompliance")]
    public partial class TheoreticalCompliance
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkCompliance", TypeName = "char(40)")]
        public string FkCompliance { get; set; }
        [Required]
        [Column("filter", TypeName = "char(50)")]
        public string Filter { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("value")]
        public double? Value { get; set; }
    }
}
