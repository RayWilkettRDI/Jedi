using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class RefAmountsCustomarilyConsumed
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(256)]
        public string LabelStatement { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkProductCategory", TypeName = "char(40)")]
        public string FkProductCategory { get; set; }
        public double Quantity { get; set; }
        [Column("fkAuthority", TypeName = "char(40)")]
        public string FkAuthority { get; set; }
    }
}
