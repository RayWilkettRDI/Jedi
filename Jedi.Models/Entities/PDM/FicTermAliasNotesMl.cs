using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ficTermAliasNotesML")]
    public partial class FicTermAliasNotesMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(150)]
        public string SpecialNotes { get; set; }
        [Column("fkTermAlias", TypeName = "char(40)")]
        public string FkTermAlias { get; set; }
    }
}
