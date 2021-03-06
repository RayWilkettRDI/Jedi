﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdPermissionTemplateItemCs")]
    public partial class NpdPermissionTemplateItemCs
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkTemplate", TypeName = "char(40)")]
        public string FkTemplate { get; set; }
        public int? Action { get; set; }
    }
}
