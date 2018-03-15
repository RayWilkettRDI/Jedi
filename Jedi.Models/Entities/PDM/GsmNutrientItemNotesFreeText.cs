using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmNutrientItemNotesFreeText")]
    public partial class GsmNutrientItemNotesFreeText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [StringLength(2048)]
        public string Notes { get; set; }
    }
}
