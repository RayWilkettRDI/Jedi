using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmPackageType")]
    public partial class GsmPackageType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("ISOCode", TypeName = "char(2)")]
        public string Isocode { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
