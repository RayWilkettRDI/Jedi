using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FoodServiceFormulations
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkIngredientSpec", TypeName = "char(40)")]
        public string FkIngredientSpec { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public bool? PubToSupplierPortal { get; set; }
        public bool? IsProprietary { get; set; }
        public bool? IsMasterFormula { get; set; }
        public bool? IsRegulatory { get; set; }
    }
}
