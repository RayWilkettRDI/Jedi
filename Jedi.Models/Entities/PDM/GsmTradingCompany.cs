using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmTradingCompany")]
    public partial class GsmTradingCompany
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTargetMarket", TypeName = "char(40)")]
        public string FkTargetMarket { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [Column("GLN")]
        [StringLength(13)]
        public string Gln { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
