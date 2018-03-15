using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class OptimizationSessions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(2)")]
        public string ReformulationPolicy { get; set; }
        [Column(TypeName = "char(2)")]
        public string ConstraintCohesion { get; set; }
        public int? ApproximateYieldPolicy { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public bool? HasOptimizationBeenRun { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [StringLength(20)]
        public string OutputDistribution { get; set; }
    }
}
