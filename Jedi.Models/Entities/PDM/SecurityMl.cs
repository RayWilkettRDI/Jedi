using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("securityML")]
    public partial class SecurityMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(40)]
        public string Name { get; set; }
    }
}
