﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmEntityFreeTextName")]
    public partial class ScrmEntityFreeTextName
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("name")]
        [StringLength(256)]
        public string Name { get; set; }
        [Column("fkentity", TypeName = "char(40)")]
        public string Fkentity { get; set; }
    }
}
