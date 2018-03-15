using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("scrmSourcingType")]
    public partial class ScrmSourcingType
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
