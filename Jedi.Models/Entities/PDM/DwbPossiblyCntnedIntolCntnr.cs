using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbPossiblyCntnedIntolCntnr")]
    public partial class DwbPossiblyCntnedIntolCntnr
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkComplianceItem", TypeName = "char(40)")]
        public string FkComplianceItem { get; set; }
        [StringLength(125)]
        public string Source { get; set; }
        [Column("fkMaxPer100gUOM", TypeName = "char(40)")]
        public string FkMaxPer100gUom { get; set; }
        public double? MaxPer100g { get; set; }
    }
}
