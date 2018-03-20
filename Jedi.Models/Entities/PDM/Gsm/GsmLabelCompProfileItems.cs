using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmLabelCompProfileItems")]
    public partial class GsmLabelCompProfileItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? PercentYield { get; set; }
        [Column("fkProfile", TypeName = "char(40)")]
        public string FkProfile { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [StringLength(4000)]
        public string Caption { get; set; }
    }
}
