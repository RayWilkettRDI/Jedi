using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class HtmlData
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "ntext")]
        public string HtmlContent { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(2500)]
        public string Keywords { get; set; }
        public bool? IsUserDefinedKeywords { get; set; }
    }
}
