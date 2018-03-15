using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("AllergenContainedSourceML")]
    public partial class AllergenContainedSourceMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkAllergen", TypeName = "char(40)")]
        public string FkAllergen { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
    }
}
