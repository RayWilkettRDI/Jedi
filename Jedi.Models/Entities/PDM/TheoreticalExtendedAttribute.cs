using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TheoreticalExtendedAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Comments { get; set; }
        [Required]
        [Column("fkExtendedAttribute", TypeName = "char(40)")]
        public string FkExtendedAttribute { get; set; }
        [Required]
        [Column("fkExtendedAttributeOverride", TypeName = "char(40)")]
        public string FkExtendedAttributeOverride { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public bool IsOverrideOnly { get; set; }
    }
}
