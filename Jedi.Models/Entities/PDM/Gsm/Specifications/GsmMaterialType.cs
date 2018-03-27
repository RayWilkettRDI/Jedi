using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("gsmMaterialType")]
    public partial class GsmMaterialType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? DexVersion { get; set; }
        [Column("TypeID")]
        public int? TypeId { get; set; }
        public bool? IsDefault { get; set; }
        public int? Status { get; set; }
    }
}
