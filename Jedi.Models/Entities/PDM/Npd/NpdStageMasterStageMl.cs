using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStageMasterStageML")]
    public partial class NpdStageMasterStageMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string StageName { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(1024)]
        public string GateDesiredAction { get; set; }
        [StringLength(1024)]
        public string StageDesiredAction { get; set; }
        [StringLength(256)]
        public string GateName { get; set; }
        [Column("fkStageMasterStage", TypeName = "char(40)")]
        public string FkStageMasterStage { get; set; }
    }
}
