﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specStorageRequirements")]
    public partial class SpecStorageRequirements
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
