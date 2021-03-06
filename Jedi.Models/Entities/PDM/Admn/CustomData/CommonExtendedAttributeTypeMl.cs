﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("commonExtendedAttributeTypeML")]
    public partial class CommonExtendedAttributeTypeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [Column("fkExtendedAttributeType", TypeName = "char(40)")]
        public string FkExtendedAttributeType { get; set; }
    }
}
