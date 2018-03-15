﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFProcessInstance")]
    public partial class ComLwfprocessInstance
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
    }
}
