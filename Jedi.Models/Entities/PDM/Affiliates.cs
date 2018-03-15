using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Affiliates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; }
        [Column("oldpkid", TypeName = "char(40)")]
        public string Oldpkid { get; set; }
    }
}
