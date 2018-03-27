using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("formSpecAttributes")]
    public partial class FormSpecAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkNutrientMeasurementUOM", TypeName = "char(40)")]
        public string FkNutrientMeasurementUom { get; set; }
        [Column("fkExperimentParent", TypeName = "char(40)")]
        public string FkExperimentParent { get; set; }
    }
}
