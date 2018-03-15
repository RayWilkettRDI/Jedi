using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class PackingSpec
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("lasteditdate", TypeName = "char(10)")]
        public string Lasteditdate { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
}
