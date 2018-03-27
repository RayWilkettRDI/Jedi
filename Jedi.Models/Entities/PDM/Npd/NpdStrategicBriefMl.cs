using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStrategicBriefML")]
    public partial class NpdStrategicBriefMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkProject", TypeName = "char(40)")]
        public string FkProject { get; set; }
    }
}
