using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("dwbSpecSubstitute")]
    public partial class DwbSpecSubstitute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkContainer", TypeName = "char(40)")]
        public string FkContainer { get; set; }
        public double? Factor { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("SubstituteID")]
        public int? SubstituteId { get; set; }
        [StringLength(150)]
        public string SpecName { get; set; }
        public int? SequenceNumber { get; set; }
    }
}
