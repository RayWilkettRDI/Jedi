using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specAnalyticalPropertyScoring")]
    public partial class SpecAnalyticalPropertyScoring
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(10)]
        public string Operand { get; set; }
        public int? Score { get; set; }
        [StringLength(50)]
        public string Value { get; set; }
        public int? Sequence { get; set; }
        [Column("fkTestingProtocolAnalytical", TypeName = "char(40)")]
        public string FkTestingProtocolAnalytical { get; set; }
    }
}
