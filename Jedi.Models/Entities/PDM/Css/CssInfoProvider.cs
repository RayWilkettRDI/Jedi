using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Css
{
    [Table("cssInfoProvider")]
    public partial class CssInfoProvider
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("GLN")]
        [StringLength(14)]
        public string Gln { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
