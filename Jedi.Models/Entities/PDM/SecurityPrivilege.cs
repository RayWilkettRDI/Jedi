using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("securityPrivilege")]
    public partial class SecurityPrivilege
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkGroup", TypeName = "char(40)")]
        public string FkGroup { get; set; }
        [Required]
        [Column("fkClassification", TypeName = "char(40)")]
        public string FkClassification { get; set; }
        [Column("readLevel")]
        public int ReadLevel { get; set; }
    }
}
