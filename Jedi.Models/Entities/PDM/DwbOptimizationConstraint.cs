using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbOptimizationConstraint")]
    public partial class DwbOptimizationConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(40)]
        public string Value1 { get; set; }
        [StringLength(40)]
        public string Value2 { get; set; }
        [StringLength(40)]
        public string Value5 { get; set; }
        [StringLength(40)]
        public string Value3 { get; set; }
        [StringLength(40)]
        public string Value4 { get; set; }
        public int? SequenceNumber { get; set; }
        [Column(TypeName = "char(2)")]
        public string ConstraintType { get; set; }
        [Column("fkDWBSpecification", TypeName = "char(40)")]
        public string FkDwbspecification { get; set; }
    }
}
