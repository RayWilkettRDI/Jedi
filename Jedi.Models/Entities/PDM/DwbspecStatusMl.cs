using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DWBSpecStatusML")]
    public partial class DwbspecStatusMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(64)]
        public string StatusName { get; set; }
        [Column("fkSpecStatus", TypeName = "char(40)")]
        public string FkSpecStatus { get; set; }
    }
}
