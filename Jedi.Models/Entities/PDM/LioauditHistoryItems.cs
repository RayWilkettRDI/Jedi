using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("LIOAuditHistoryItems")]
    public partial class LioauditHistoryItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("SourceElementID", TypeName = "char(40)")]
        public string SourceElementId { get; set; }
        [Column("ElementID", TypeName = "char(40)")]
        public string ElementId { get; set; }
        [Column("TargetElementID", TypeName = "char(40)")]
        public string TargetElementId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [Column("fkLIORoot", TypeName = "char(40)")]
        public string FkLioroot { get; set; }
        [Column("EventTypeID", TypeName = "char(40)")]
        public string EventTypeId { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        [StringLength(20)]
        public string DisplayFormatId { get; set; }
    }
}
