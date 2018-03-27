using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Lio
{
    [Table("lioprofiles")]
    public partial class Lioprofiles
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [Column("lionumber", TypeName = "char(8)")]
        public string Lionumber { get; set; }
        [Column("fkTargetIngredient", TypeName = "char(40)")]
        public string FkTargetIngredient { get; set; }
        [Column("fkTargetNutrientProfile", TypeName = "char(40)")]
        public string FkTargetNutrientProfile { get; set; }
        [Column("fkContext", TypeName = "char(40)")]
        public string FkContext { get; set; }
        [Column("LIOCustomizedStatement")]
        [StringLength(4000)]
        public string LiocustomizedStatement { get; set; }
        public int? SystemVersion { get; set; }
    }
}
