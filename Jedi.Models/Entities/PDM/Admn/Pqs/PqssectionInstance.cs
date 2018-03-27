using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSSectionInstance")]
    public partial class PqssectionInstance
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSection")]
        [StringLength(40)]
        public string FkSection { get; set; }
        public double? WeightedScore { get; set; }
        public double? Score { get; set; }
        [Column("fkSectionInstance")]
        [StringLength(40)]
        public string FkSectionInstance { get; set; }
        [Column("fkScorecard")]
        [StringLength(40)]
        public string FkScorecard { get; set; }
        public bool? InputComplete { get; set; }
    }
}
