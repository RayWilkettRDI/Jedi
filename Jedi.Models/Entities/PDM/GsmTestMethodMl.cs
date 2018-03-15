﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmTestMethodML")]
    public partial class GsmTestMethodMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Required]
        [Column("fkTestMethod", TypeName = "char(40)")]
        public string FkTestMethod { get; set; }
    }
}
