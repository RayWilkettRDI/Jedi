using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdActProjSchedCustMilestoneML")]
    public partial class NpdActProjSchedCustMilestoneMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(32)]
        public string Caption { get; set; }
        [Column("fkCustomMilestone", TypeName = "char(40)")]
        public string FkCustomMilestone { get; set; }
    }
}
