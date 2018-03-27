using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("gsmPackagingMaterial")]
    public partial class GsmPackagingMaterial
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Type { get; set; }
        [Column("CSUnits")]
        public int? Csunits { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkPkgSpec", TypeName = "char(40)")]
        public string FkPkgSpec { get; set; }
    }
}
