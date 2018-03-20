using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Compliance
{
    public partial class Additives
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(125)]
        public string Name { get; set; }
        [Column("langid")]
        public int Langid { get; set; }
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
