using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class IngStatementFreeText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("statement")]
        [StringLength(4000)]
        public string Statement { get; set; }
        [Required]
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(4000)]
        public string StatementRich { get; set; }
    }
}
