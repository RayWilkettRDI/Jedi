using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonTranslationCaches")]
    public partial class CommonTranslationCaches
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("ID")]
        [StringLength(100)]
        public string Id { get; set; }
        [Column("fkBase", TypeName = "char(40)")]
        public string FkBase { get; set; }
        public int? LastTransactionId { get; set; }
    }
}
