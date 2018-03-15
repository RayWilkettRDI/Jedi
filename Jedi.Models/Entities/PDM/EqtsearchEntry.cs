using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("EQTSearchEntry")]
    public partial class EqtsearchEntry
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string ModelName { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [StringLength(64)]
        public string FilterType { get; set; }
        [Column(TypeName = "ntext")]
        public string Name { get; set; }
    }
}
