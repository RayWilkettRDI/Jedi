using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Formulation
{
    [Table("gsmFormulationSubMaterial")]
    public partial class GsmFormulationSubMaterial
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkMaterial", TypeName = "char(40)")]
        public string FkMaterial { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("factor")]
        public double? Factor { get; set; }
        public int? Ranking { get; set; }
    }
}
