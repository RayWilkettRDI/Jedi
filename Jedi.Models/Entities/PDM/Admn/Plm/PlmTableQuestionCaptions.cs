using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmTableQuestionCaptions")]
    public partial class PlmTableQuestionCaptions
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("langValue")]
        [StringLength(1024)]
        public string LangValue { get; set; }
    }
}
