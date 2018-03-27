using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.ComponentCatalog
{
    [Table("ccmsImportType")]
    public partial class CcmsImportType
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langValue")]
        [StringLength(100)]
        public string LangValue { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
