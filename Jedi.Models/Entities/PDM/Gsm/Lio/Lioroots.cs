using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Lio
{
    [Table("LIORoots")]
    public partial class Lioroots
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? DisplayMessagePercentThreshold { get; set; }
        public bool? ShowActiveRows { get; set; }
        [StringLength(10)]
        public string StatementFormat { get; set; }
        [Column("fkDWBSpec", TypeName = "char(40)")]
        public string FkDwbspec { get; set; }
        [StringLength(14)]
        public string StatementStyle { get; set; }
        public bool? HasBeenStarted { get; set; }
        [Column("fkDisplayMessagePctThreshold", TypeName = "char(40)")]
        public string FkDisplayMessagePctThreshold { get; set; }
        [Column("fkStatementStyleLookupItem", TypeName = "char(40)")]
        public string FkStatementStyleLookupItem { get; set; }
        [Column("fkStatementFormat", TypeName = "char(40)")]
        public string FkStatementFormat { get; set; }
    }
}
