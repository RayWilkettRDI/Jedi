using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonLookups")]
    public partial class CommonLookups
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(150)")]
        public string Category { get; set; }
        public int? SortOrder { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public int? OptionalValue { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
