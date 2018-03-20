using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmCompanySpecialAttributes")]
    public partial class ScrmCompanySpecialAttributes
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
