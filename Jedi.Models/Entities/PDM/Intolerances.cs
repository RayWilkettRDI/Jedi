using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Intolerances
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
