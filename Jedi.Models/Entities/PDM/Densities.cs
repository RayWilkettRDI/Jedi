using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Densities
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? MassValue { get; set; }
        [Column("fkMassUOM", TypeName = "char(40)")]
        public string FkMassUom { get; set; }
        public double? VolumeValue { get; set; }
        [Column("fkVolumeUOM", TypeName = "char(40)")]
        public string FkVolumeUom { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(32)]
        public string Type { get; set; }
    }
}
