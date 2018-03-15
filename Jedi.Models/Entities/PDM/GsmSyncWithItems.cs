using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmSyncWithItems")]
    public partial class GsmSyncWithItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("GLN", TypeName = "char(14)")]
        public string Gln { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkTargetMarket", TypeName = "char(40)")]
        public string FkTargetMarket { get; set; }
    }
}
