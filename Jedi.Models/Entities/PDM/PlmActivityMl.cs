using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmActivityML")]
    public partial class PlmActivityMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(128)]
        public string Title { get; set; }
        [Column("fkActivity", TypeName = "char(40)")]
        public string FkActivity { get; set; }
    }
}
