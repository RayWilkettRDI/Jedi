using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specLegacySpecJoin")]
    public partial class SpecLegacySpecJoin
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [Column("fkLegacyProfileID", TypeName = "char(40)")]
        public string FkLegacyProfileId { get; set; }
        [StringLength(50)]
        public string Equivalent { get; set; }
        public bool? ExtManaged { get; set; }
        [Column(TypeName = "char(40)")]
        public string Status { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
    }
}
