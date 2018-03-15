using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonCacheFlushRequest")]
    public partial class CommonCacheFlushRequest
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(250)]
        public string Name { get; set; }
        [Column("containedItemIDs")]
        [StringLength(1025)]
        public string ContainedItemIds { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("ID")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("requestDate", TypeName = "datetime")]
        public DateTime? RequestDate { get; set; }
        [Column("sequenceNumber")]
        public int SequenceNumber { get; set; }
        [Column(TypeName = "char(36)")]
        public string CorrelationId { get; set; }
        [Column("description")]
        [StringLength(80)]
        public string Description { get; set; }
    }
}
