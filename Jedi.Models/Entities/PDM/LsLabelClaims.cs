using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("lsLabelClaims")]
    public partial class LsLabelClaims
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? Active { get; set; }
        public bool? IsCalculatable { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
