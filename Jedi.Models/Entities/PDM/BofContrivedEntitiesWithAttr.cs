using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("bofContrivedEntitiesWithAttr")]
    public partial class BofContrivedEntitiesWithAttr
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string PropertyB { get; set; }
        public int? PropertyA { get; set; }
    }
}
