using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    public partial class SpecMatAttribFreeText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("instructions")]
        [StringLength(2048)]
        public string Instructions { get; set; }
        [Required]
        [Column("fkIngredientAttributes", TypeName = "char(40)")]
        public string FkIngredientAttributes { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
