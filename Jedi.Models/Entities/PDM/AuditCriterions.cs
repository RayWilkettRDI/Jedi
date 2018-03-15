using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditCriterions")]
    public partial class AuditCriterions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(7)")]
        public string CriteriaNumber { get; set; }
        public int? NonConformanceOperatorCode { get; set; }
        [Column("RatingFactorID")]
        public int? RatingFactorId { get; set; }
        public int? CriterionType { get; set; }
        public int? CriteriaOrder { get; set; }
        [Column(TypeName = "char(3)")]
        public string InputDataTypeCode { get; set; }
        public double? DefaultScore { get; set; }
        public double? Weight { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public double? NonConformanceValue { get; set; }
        [StringLength(256)]
        public string CalculationFormula { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
    }
}
