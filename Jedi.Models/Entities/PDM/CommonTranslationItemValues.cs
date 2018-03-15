using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonTranslationItemValues")]
    public partial class CommonTranslationItemValues
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langValue")]
        [StringLength(2000)]
        public string LangValue { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Required]
        [Column("fkTranslationItem", TypeName = "char(40)")]
        public string FkTranslationItem { get; set; }
        public int? LastTransactionId { get; set; }
    }
}
