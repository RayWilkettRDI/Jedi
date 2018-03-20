using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Cacs
{
    [Table("CACSUsageApprovalConstraint")]
    public partial class CacsusageApprovalConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAttribute", TypeName = "char(40)")]
        public string FkAttribute { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        public int? ConstraintOperator { get; set; }
        [Column("fkBusinessUnit", TypeName = "char(40)")]
        public string FkBusinessUnit { get; set; }
        public double? ConstraintValue { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public int? Sequence { get; set; }
        [Column("fkConcept", TypeName = "char(40)")]
        public string FkConcept { get; set; }
        [Column("fkSegment", TypeName = "char(40)")]
        public string FkSegment { get; set; }
    }
}
