using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Global
{
    [Table("SupportedLanguages")]
    public partial class SupportedLanguages
    {
        [Column("langName")]
        [StringLength(256)]
        public string LangName { get; set; }

        [Key]
        [Required]
        [Column("langID")]
        public int LangId { get; set; }

        [Required]
        [Column("active")]
        public int Active { get; set; }

        [Required]
        [Column("defaultcultureID")]
        public int DefaultCultureId { get; set; }

        [Required]
        [Column("IsDataObjectLanguage")]
        public int IsDataObjectLanguage { get; set; }

        [Column("IsNLS")]
        public int IsNls { get; set; }
    }
}
