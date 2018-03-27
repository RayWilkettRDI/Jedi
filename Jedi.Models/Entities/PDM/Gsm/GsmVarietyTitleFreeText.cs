using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmVarietyTitleFreeText")]
    public partial class GsmVarietyTitleFreeText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [StringLength(128)]
        public string Title { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
