using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FormulationOutputSettings
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? PushExtendedAttributeValues { get; set; }
        public bool? PushNutrientValues { get; set; }
        public bool? PushCustomSectionValues { get; set; }
        public bool? PushDesignAttributes { get; set; }
        public bool? PushComplianceValues { get; set; }
        public bool? PushBreakdown { get; set; }
        [Column("fkParentOutput", TypeName = "char(40)")]
        public string FkParentOutput { get; set; }
    }
}
