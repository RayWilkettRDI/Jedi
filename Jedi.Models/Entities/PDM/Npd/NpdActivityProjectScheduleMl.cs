using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActivityProjectScheduleML")]
    public partial class NpdActivityProjectScheduleMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string InMarketLaunchComments { get; set; }
        [Column("fkActivityProjectSchedule", TypeName = "char(40)")]
        public string FkActivityProjectSchedule { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
