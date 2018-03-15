using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("PQSSessionToSample")]
    public partial class PqssessionToSample
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSample", TypeName = "char(40)")]
        public string FkSample { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkSession", TypeName = "char(40)")]
        public string FkSession { get; set; }
    }
}
