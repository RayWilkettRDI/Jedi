using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Global
{
    [Table("commonSegment")]
    public partial class CommonSegment
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("ExternalID")]
        [StringLength(200)]
        public string ExternalId { get; set; }
        [Column("fkSegment", TypeName = "char(40)")]
        public string FkSegment { get; set; }
        public int? Status { get; set; }
        public int? IsPhantom { get; set; }
    }
}
