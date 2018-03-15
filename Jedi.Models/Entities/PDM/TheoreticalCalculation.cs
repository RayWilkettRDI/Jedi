using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TheoreticalCalculation
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimestampOfSubcomponentAttrs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimestampOfEnvWastes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimestampOfExtendedAttributes { get; set; }
    }
}
