using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class CostMessages
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("OrganizationUnitID")]
        [StringLength(48)]
        public string OrganizationUnitId { get; set; }
        [StringLength(100)]
        public string PrincipalName { get; set; }
        [StringLength(10)]
        public string CostCulture { get; set; }
        [Column("MessageID")]
        [StringLength(128)]
        public string MessageId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MessageTimestamp { get; set; }
        public int? SequenceNumber { get; set; }
    }
}
