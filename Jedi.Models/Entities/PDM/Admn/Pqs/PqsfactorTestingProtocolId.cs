using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSFactorTestingProtocolID")]
    public partial class PqsfactorTestingProtocolId
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Frequency { get; set; }
        [Column("fkFactor", TypeName = "char(40)")]
        public string FkFactor { get; set; }
        [Column("TestingProtocolID")]
        [StringLength(128)]
        public string TestingProtocolId { get; set; }
    }
}
