using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdStageTemplates")]
    public partial class NpdStageTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? AutoApprove { get; set; }
        [Column("SignatureRequestSLAAmberDays")]
        public int? SignatureRequestSlaamberDays { get; set; }
        public int? StageNumber { get; set; }
        [Column("SignatureRequestSLARedDays")]
        public int? SignatureRequestSlaredDays { get; set; }
        [Column("fkProjectTemplate", TypeName = "char(40)")]
        public string FkProjectTemplate { get; set; }
        [Column("fkQuestionDocumentTemplate", TypeName = "char(40)")]
        public string FkQuestionDocumentTemplate { get; set; }
        [Column("secondReviewAccelFactorPct")]
        public int? SecondReviewAccelFactorPct { get; set; }
        [StringLength(20)]
        public string ResolutionStrategy { get; set; }
    }
}
