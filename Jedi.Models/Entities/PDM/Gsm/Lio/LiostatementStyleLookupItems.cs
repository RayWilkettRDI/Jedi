using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Lio
{
    [Table("LIOStatementStyleLookupItems")]
    public partial class LiostatementStyleLookupItems
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsUppercase { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(12)]
        public string Delimiter { get; set; }
        public int? SortOrder { get; set; }
        [StringLength(125)]
        public string Caption { get; set; }
    }
}
