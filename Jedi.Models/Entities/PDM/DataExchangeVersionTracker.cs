using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class DataExchangeVersionTracker
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Type { get; set; }
        public double? CurrentVersion { get; set; }
        [StringLength(1024)]
        public string TypeQualifier { get; set; }
    }
}
