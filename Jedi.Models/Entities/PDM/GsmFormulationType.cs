﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmFormulationType")]
    public partial class GsmFormulationType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("TypeID")]
        public int? TypeId { get; set; }
        public bool? IsDefault { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
