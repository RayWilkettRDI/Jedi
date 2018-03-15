using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmShortNameML")]
    public partial class GsmShortNameMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpecSummary", TypeName = "char(40)")]
        public string FkSpecSummary { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
