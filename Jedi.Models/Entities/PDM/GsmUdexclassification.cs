﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmUDEXClassification")]
    public partial class GsmUdexclassification
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
    }
}
