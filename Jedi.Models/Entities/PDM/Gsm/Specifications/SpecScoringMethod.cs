﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("specScoringMethod")]
    public partial class SpecScoringMethod
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(2)")]
        public string MethodCode { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
