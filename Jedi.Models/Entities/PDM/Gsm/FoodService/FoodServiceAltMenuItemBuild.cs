using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.FoodService
{
    public partial class FoodServiceAltMenuItemBuild
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        [Column("fkAlternate", TypeName = "char(40)")]
        public string FkAlternate { get; set; }
        public double? SubstituteFactor { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [Column(TypeName = "nchar(12)")]
        public string Original { get; set; }
        public bool IsCustomAssociation { get; set; }
        [Column("fkOriginal")]
        [StringLength(40)]
        public string FkOriginal { get; set; }
    }
}
