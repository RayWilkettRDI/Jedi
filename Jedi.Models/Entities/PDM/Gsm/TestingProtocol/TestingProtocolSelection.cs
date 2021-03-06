﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.TestingProtocol
{
    public partial class TestingProtocolSelection
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("value")]
        [StringLength(128)]
        public string Value { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
