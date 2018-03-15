using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmMatBreakdownDescFreeText")]
    public partial class GsmMatBreakdownDescFreeText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkIngredientBreakdown", TypeName = "char(40)")]
        public string FkIngredientBreakdown { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(2048)]
        public string Description { get; set; }
    }
}
