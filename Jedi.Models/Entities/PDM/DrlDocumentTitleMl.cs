using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DrlDocumentTitleML")]
    public partial class DrlDocumentTitleMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkDocument", TypeName = "char(40)")]
        public string FkDocument { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
