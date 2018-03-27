using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.TestingProtocol
{
    public partial class TestingProtocol
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("lastEditDate", TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("sequence")]
        public int? Sequence { get; set; }
        [Column("TPIDHigh")]
        public int? Tpidhigh { get; set; }
        public int? Scope { get; set; }
        [StringLength(7)]
        public string Id { get; set; }
        public int? Status { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
    }
}
