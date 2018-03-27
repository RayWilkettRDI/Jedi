using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Formulation
{
    [Table("gsmFormulationSpecAttributes")]
    public partial class GsmFormulationSpecAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFormulationSnapshot", TypeName = "char(40)")]
        public string FkFormulationSnapshot { get; set; }
        [Column("fkProject", TypeName = "char(40)")]
        public string FkProject { get; set; }
        [StringLength(250)]
        public string ProjectName { get; set; }
    }
}
