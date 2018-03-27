using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmAnalyticML")]
    public partial class PlmAnalyticMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("title")]
        [StringLength(256)]
        public string Title { get; set; }
        [Column("fkAnalytic", TypeName = "char(40)")]
        public string FkAnalytic { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
