using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class WasteMaterialClass
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
