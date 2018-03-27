using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    public partial class IngCombStatementsFreeText
    {
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [StringLength(4000)]
        public string CombinedStatement { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(4000)]
        public string CombinedStatementRich { get; set; }
    }
}
