﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("RACCProductCategory")]
    public partial class RaccproductCategory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
