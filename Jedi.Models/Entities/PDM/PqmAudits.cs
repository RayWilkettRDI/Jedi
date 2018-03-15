using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("pqmAudits")]
    public partial class PqmAudits
    {
        [Key]
        [Column("pkid", TypeName = "char(10)")]
        public string Pkid { get; set; }
        [Column("fkPQMType", TypeName = "char(40)")]
        public string FkPqmtype { get; set; }
        [Column("fkAuditResult", TypeName = "char(40)")]
        public string FkAuditResult { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlannedAuditDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualAuditDate { get; set; }
    }
}
