﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.NutrientProfile
{
    [Table("gsmNutrientExtendedAttribute")]
    public partial class GsmNutrientExtendedAttribute
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
