using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class CostOptimizationConstraints
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? Price { get; set; }
        public int? HandlingUnit { get; set; }
        [StringLength(3)]
        public string Operator { get; set; }
        public int? Sequenece { get; set; }
        [Column("fkParentSession", TypeName = "char(40)")]
        public string FkParentSession { get; set; }
        [Column("fkCurrency", TypeName = "char(40)")]
        public string FkCurrency { get; set; }
    }
}
