using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class CustomLookup
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkCategory", TypeName = "char(40)")]
        public string FkCategory { get; set; }
        [StringLength(80)]
        public string ExternalId { get; set; }
        [StringLength(150)]
        public string Value { get; set; }
        public int? SortOrder { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public int? Status { get; set; }
    }
}
