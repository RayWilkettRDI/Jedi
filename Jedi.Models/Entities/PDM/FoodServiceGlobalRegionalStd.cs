using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class FoodServiceGlobalRegionalStd
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStandard", TypeName = "char(40)")]
        public string FkStandard { get; set; }
        [Column("fkAlternate", TypeName = "char(40)")]
        public string FkAlternate { get; set; }
    }
}
