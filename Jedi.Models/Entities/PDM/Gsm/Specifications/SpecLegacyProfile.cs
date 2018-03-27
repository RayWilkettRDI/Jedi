using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specLegacyProfile")]
    public partial class SpecLegacyProfile
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(50)]
        public string SystemName { get; set; }
        [Required]
        [StringLength(50)]
        public string SystemCode { get; set; }
        [StringLength(75)]
        public string AffiliateName { get; set; }
        [Column("fkContactID", TypeName = "char(40)")]
        public string FkContactId { get; set; }
        [Column("fkSpecBusinessUnit", TypeName = "char(40)")]
        public string FkSpecBusinessUnit { get; set; }
        public bool? ExtManagedDefault { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
