using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class CostItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkCostMessage", TypeName = "char(40)")]
        public string FkCostMessage { get; set; }
        [StringLength(24)]
        public string Equivalent { get; set; }
        [Column("fkSCRMEntity", TypeName = "char(40)")]
        public string FkScrmentity { get; set; }
        [StringLength(12)]
        public string CostType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkCurrency", TypeName = "char(40)")]
        public string FkCurrency { get; set; }
        [Column("fkLegacyProfile", TypeName = "char(40)")]
        public string FkLegacyProfile { get; set; }
        public double? Cost { get; set; }
    }
}
