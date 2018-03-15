using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmLanguages")]
    public partial class GsmLanguages
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
