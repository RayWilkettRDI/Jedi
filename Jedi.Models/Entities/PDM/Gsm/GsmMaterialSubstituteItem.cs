using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmMaterialSubstituteItem")]
    public partial class GsmMaterialSubstituteItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? Factor { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkMaterial", TypeName = "char(40)")]
        public string FkMaterial { get; set; }
        public double? GainLossFactor { get; set; }
        public bool? IsCustomAssociation { get; set; }
        [Column("fkContext", TypeName = "char(40)")]
        public string FkContext { get; set; }
        [Column("fkPackSize", TypeName = "char(40)")]
        public string FkPackSize { get; set; }
    }
}
