using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonXLAExtensionCache")]
    public partial class CommonXlaextensionCache
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(1024)]
        public string InheritFrom { get; set; }
        [StringLength(256)]
        public string Category { get; set; }
    }
}
