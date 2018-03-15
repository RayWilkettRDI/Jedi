using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmTPSelectionFrequencyJoin")]
    public partial class GsmTpselectionFrequencyJoin
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTPSelection", TypeName = "char(40)")]
        public string FkTpselection { get; set; }
        public int? Frequency { get; set; }
        [Column("fkTPAnalyticalProperty", TypeName = "char(40)")]
        public string FkTpanalyticalProperty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
