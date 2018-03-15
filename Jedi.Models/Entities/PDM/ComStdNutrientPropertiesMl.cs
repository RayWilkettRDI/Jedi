using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comStdNutrientPropertiesML")]
    public partial class ComStdNutrientPropertiesMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStandardNutrientProperties", TypeName = "char(40)")]
        public string FkStandardNutrientProperties { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public int? OldStatus { get; set; }
    }
}
