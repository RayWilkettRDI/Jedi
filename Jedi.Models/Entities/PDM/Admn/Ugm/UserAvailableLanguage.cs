using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Ugm
{
    public partial class UserAvailableLanguage
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("languageID")]
        public int? LanguageId { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
    }
}
