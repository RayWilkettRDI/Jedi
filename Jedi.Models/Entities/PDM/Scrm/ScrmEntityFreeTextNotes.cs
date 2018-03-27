using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmEntityFreeTextNotes")]
    public partial class ScrmEntityFreeTextNotes
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkEntity", TypeName = "char(40)")]
        public string FkEntity { get; set; }
        [Column("langid")]
        public int Langid { get; set; }
        [Column("notes")]
        [StringLength(2000)]
        public string Notes { get; set; }
    }
}
