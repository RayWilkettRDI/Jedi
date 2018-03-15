using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TimeInterval
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string TimeValue { get; set; }
        public int Sequence { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
