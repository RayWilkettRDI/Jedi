using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSSection")]
    public partial class Pqssection
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTemplate")]
        [StringLength(40)]
        public string FkTemplate { get; set; }
        public double? Weight { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkSection")]
        [StringLength(40)]
        public string FkSection { get; set; }
        [Column("SectionSnapshotID", TypeName = "char(40)")]
        public string SectionSnapshotId { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Column(TypeName = "char(1)")]
        public string StrategyTypeCode { get; set; }
    }
}
