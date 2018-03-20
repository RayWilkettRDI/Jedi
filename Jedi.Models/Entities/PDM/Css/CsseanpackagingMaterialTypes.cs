using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Css
{
    [Table("CSSEANPackagingMaterialTypes")]
    public partial class CsseanpackagingMaterialTypes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
