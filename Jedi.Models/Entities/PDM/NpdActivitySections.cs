using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActivitySections")]
    public partial class NpdActivitySections
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public int? SectionNumber { get; set; }
        public bool? IsComplete { get; set; }
        [Column("fkActivity", TypeName = "char(40)")]
        public string FkActivity { get; set; }
        [StringLength(50)]
        public string SectionName { get; set; }
    }
}
