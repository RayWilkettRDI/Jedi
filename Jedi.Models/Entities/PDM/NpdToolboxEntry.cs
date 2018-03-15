using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdToolboxEntry")]
    public partial class NpdToolboxEntry
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(1000)]
        public string Objective { get; set; }
        public int? SequenceNum { get; set; }
        [Column("fkEntityAttachment", TypeName = "char(40)")]
        public string FkEntityAttachment { get; set; }
    }
}
