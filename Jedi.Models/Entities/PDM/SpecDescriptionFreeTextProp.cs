using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SpecDescriptionFreeTextProp
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        [Required]
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
