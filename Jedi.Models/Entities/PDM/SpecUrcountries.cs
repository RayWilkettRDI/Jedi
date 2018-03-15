using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specURCountries")]
    public partial class SpecUrcountries
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpecUsageRestriction", TypeName = "char(40)")]
        public string FkSpecUsageRestriction { get; set; }
        [Required]
        [Column("fkCountries", TypeName = "char(40)")]
        public string FkCountries { get; set; }
    }
}
