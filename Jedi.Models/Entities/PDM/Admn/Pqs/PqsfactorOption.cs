using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSFactorOption")]
    public partial class PqsfactorOption
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? Score { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public double? Value { get; set; }
        public int? Operator { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkFactor")]
        [StringLength(40)]
        public string FkFactor { get; set; }
    }
}
