using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqMarkingML")]
    public partial class EqMarkingMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("fkEQMarking", TypeName = "char(40)")]
        public string FkEqmarking { get; set; }
    }
}
