using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("LIODisplayMessagePctThreshold")]
    public partial class LiodisplayMessagePctThreshold
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? SortOrder { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(125)]
        public string Caption { get; set; }
        public double? ThresholdPercent { get; set; }
    }
}
