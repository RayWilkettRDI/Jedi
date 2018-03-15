using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("PQSFactorInstance")]
    public partial class PqsfactorInstance
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? CalculatedValue { get; set; }
        public int? Scored { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [StringLength(256)]
        public string InputValue { get; set; }
        public double? Score { get; set; }
        [Column("fkFactor", TypeName = "char(40)")]
        public string FkFactor { get; set; }
        [Column("fkSectionInstance")]
        [StringLength(40)]
        public string FkSectionInstance { get; set; }
        public double? Weight { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
    }
}
