using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmTradeType")]
    public partial class GsmTradeType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("TypeID")]
        public int? TypeId { get; set; }
        public bool? IsDiscrete { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
        [Column("isDefault")]
        public bool IsDefault { get; set; }
    }
}
