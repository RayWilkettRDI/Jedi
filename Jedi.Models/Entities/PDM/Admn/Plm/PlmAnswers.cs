﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmAnswers")]
    public partial class PlmAnswers
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(2000)]
        public string Answer { get; set; }
        [Column("fkQuestion", TypeName = "char(40)")]
        public string FkQuestion { get; set; }
    }
}
