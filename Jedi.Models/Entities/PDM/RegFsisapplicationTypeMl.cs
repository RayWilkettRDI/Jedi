﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("regFSISApplicationTypeML")]
    public partial class RegFsisapplicationTypeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkApplicationType", TypeName = "char(40)")]
        public string FkApplicationType { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
