using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Compliance
{
    public partial class ComplianceItemContainedSource
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [Column("fkComplianceItemContained", TypeName = "char(40)")]
        public string FkComplianceItemContained { get; set; }
    }
}
