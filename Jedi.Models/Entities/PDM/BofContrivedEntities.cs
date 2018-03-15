using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("bofContrivedEntities")]
    public partial class BofContrivedEntities
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Property1 { get; set; }
        public bool? IsMarkedAsDel { get; set; }
    }
}
