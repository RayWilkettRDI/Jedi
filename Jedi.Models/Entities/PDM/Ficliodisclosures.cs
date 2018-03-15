using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FICLIODisclosures")]
    public partial class Ficliodisclosures
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkPriority", TypeName = "char(40)")]
        public string FkPriority { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkDisplayMethod", TypeName = "char(40)")]
        public string FkDisplayMethod { get; set; }
    }
}
