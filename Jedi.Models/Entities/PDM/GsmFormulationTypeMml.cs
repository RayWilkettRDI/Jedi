using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmFormulationTypeMML")]
    public partial class GsmFormulationTypeMml
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFormulationType", TypeName = "char(40)")]
        public string FkFormulationType { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
