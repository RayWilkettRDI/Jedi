using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("EATypeAllowedTargetSpecsMap")]
    public partial class EatypeAllowedTargetSpecsMap
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column(TypeName = "char(40)")]
        public string ExtendedAttributeTypeId { get; set; }
    }
}
