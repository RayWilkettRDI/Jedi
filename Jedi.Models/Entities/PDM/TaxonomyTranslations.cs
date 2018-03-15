using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TaxonomyTranslations
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(75)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
