using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStrategicBriefTemplates")]
    public partial class NpdStrategicBriefTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("SignatureRequestSLARedDays")]
        public int? SignatureRequestSlaredDays { get; set; }
        [Column("SignatureRequestSLAAmberDays")]
        public int? SignatureRequestSlaamberDays { get; set; }
        public bool? AutoApprove { get; set; }
        [Column("fkQuestionDocumentTemplate", TypeName = "char(40)")]
        public string FkQuestionDocumentTemplate { get; set; }
        public bool? IsMasterTemplate { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
        public bool? CanAddRemoveExtendedAttribute { get; set; }
        public bool? CanAddRemoveCustomSection { get; set; }
        public bool? AllowEditsWhenComplete { get; set; }
        [StringLength(20)]
        public string ResolutionStrategy { get; set; }
    }
}
