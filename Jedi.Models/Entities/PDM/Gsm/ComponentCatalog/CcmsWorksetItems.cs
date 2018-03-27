using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.ComponentCatalog
{
    [Table("ccmsWorksetItems")]
    public partial class CcmsWorksetItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("languageValue")]
        [StringLength(500)]
        public string LanguageValue { get; set; }
        [Column("languageID")]
        public int? LanguageId { get; set; }
        [Column("fkTranslationItemValue", TypeName = "char(40)")]
        public string FkTranslationItemValue { get; set; }
        [Column("fkWorkset", TypeName = "char(40)")]
        public string FkWorkset { get; set; }
    }
}
