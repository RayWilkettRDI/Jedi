using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("securityAccessLevel")]
    public partial class SecurityAccessLevel
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("accessLevel")]
        public int AccessLevel { get; set; }
        [Column("sequence")]
        public int Sequence { get; set; }
    }
}
