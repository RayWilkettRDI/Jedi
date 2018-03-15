using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqIntolerances")]
    public partial class EqIntolerances
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(125)]
        public string Source { get; set; }
        [Column("fkComplianceItemPKID", TypeName = "char(40)")]
        public string FkComplianceItemPkid { get; set; }
        public double? MaxPer100g { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public int? ItemExists { get; set; }
        [Column("fkMaxPer100gUOM", TypeName = "char(40)")]
        public string FkMaxPer100gUom { get; set; }
    }
}
