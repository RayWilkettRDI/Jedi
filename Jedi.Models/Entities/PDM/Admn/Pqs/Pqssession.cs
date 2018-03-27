using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSSession")]
    public partial class Pqssession
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EvaluationDate { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("fkLocation", TypeName = "char(40)")]
        public string FkLocation { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [StringLength(200)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkTestingProtocol", TypeName = "char(40)")]
        public string FkTestingProtocol { get; set; }
        [Column("fkScorecardType", TypeName = "char(40)")]
        public string FkScorecardType { get; set; }
        public bool? IsComplete { get; set; }
        [Column("InternalSessionID")]
        [StringLength(15)]
        public string InternalSessionId { get; set; }
    }
}
