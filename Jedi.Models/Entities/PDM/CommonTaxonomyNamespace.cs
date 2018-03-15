﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonTaxonomyNamespace")]
    public partial class CommonTaxonomyNamespace
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string FactoryClassname { get; set; }
        [Column("NamespaceID")]
        [StringLength(32)]
        public string NamespaceId { get; set; }
        [StringLength(256)]
        public string ConfigValues { get; set; }
        public double? DexVersion { get; set; }
    }
}
