using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FormulationCompostionMappings
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParentStep", TypeName = "char(40)")]
        public string FkParentStep { get; set; }
        public double? InputQuantity { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkFormulationOutput", TypeName = "char(40)")]
        public string FkFormulationOutput { get; set; }
        [Column("fkFormulationInput", TypeName = "char(40)")]
        public string FkFormulationInput { get; set; }
    }
}
