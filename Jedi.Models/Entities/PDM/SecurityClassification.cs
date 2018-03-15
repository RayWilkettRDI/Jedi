using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("securityClassification")]
    public partial class SecurityClassification
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("isContextual")]
        public bool IsContextual { get; set; }
        [Required]
        [Column("fkSecuredObjectType", TypeName = "char(40)")]
        public string FkSecuredObjectType { get; set; }
    }
}
