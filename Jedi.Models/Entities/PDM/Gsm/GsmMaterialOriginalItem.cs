﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmMaterialOriginalItem")]
    public partial class GsmMaterialOriginalItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkMaterial", TypeName = "char(40)")]
        public string FkMaterial { get; set; }
        public bool? IsCustomAssociation { get; set; }
        [Column("fkStep")]
        [StringLength(40)]
        public string FkStep { get; set; }
    }
}
