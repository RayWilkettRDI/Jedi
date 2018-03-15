using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SpecAuditHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Type { get; set; }
        [Column("fkSpecSummaryID", TypeName = "char(40)")]
        public string FkSpecSummaryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDateTime { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column("fkUserID", TypeName = "char(40)")]
        public string FkUserId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("comments")]
        [StringLength(256)]
        public string Comments { get; set; }
    }
}
