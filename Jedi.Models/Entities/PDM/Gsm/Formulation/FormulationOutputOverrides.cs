using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Formulation
{
    public partial class FormulationOutputOverrides
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParentOutput", TypeName = "char(40)")]
        public string FkParentOutput { get; set; }
        public bool? LeaveClassificationsBlank { get; set; }
        [Column("fkNutrientMesurementUOM", TypeName = "char(40)")]
        public string FkNutrientMesurementUom { get; set; }
    }
}
