using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TestProtocolAnalytSpecLimits
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("speclimits")]
        [StringLength(1000)]
        public string Speclimits { get; set; }
        [Required]
        [Column("fkAnalyticalProperty", TypeName = "char(40)")]
        public string FkAnalyticalProperty { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
