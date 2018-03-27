using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStageMasterStages")]
    public partial class NpdStageMasterStages
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? StageNumber { get; set; }
        [Column("DefaultQuestionDocumentID")]
        [StringLength(80)]
        public string DefaultQuestionDocumentId { get; set; }
        public double? DexVersion { get; set; }
        [Column("fkGateStatus", TypeName = "char(40)")]
        public string FkGateStatus { get; set; }
        [Column("fkStageStatus", TypeName = "char(40)")]
        public string FkStageStatus { get; set; }
    }
}
