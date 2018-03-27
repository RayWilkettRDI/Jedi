using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Dwb.Gsm.Specifications
{
    [Table("dwbBreakdownSummary")]
    public partial class DwbBreakdownSummary
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2400)]
        public string Description { get; set; }
        [Column("fkDWBSpecAttribute", TypeName = "char(40)")]
        public string FkDwbspecAttribute { get; set; }
        [Column("ID")]
        [StringLength(128)]
        public string Id { get; set; }
        public bool? IsProprietary { get; set; }
        public bool? IsRegulatory { get; set; }
        public bool? PubToSupplierPortal { get; set; }
        public bool? IsMasterFormula { get; set; }
    }
}
