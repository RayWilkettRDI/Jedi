using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonManagedDocument")]
    public partial class CommonManagedDocument
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpirationDate { get; set; }
        [Column("fkType", TypeName = "char(40)")]
        public string FkType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequirementDate { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        public int? NotifyNumberDaysPrior { get; set; }
        public bool? NotifyRenewal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
    }
}
