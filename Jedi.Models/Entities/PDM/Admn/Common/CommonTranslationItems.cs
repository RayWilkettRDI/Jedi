using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonTranslationItems")]
    public partial class CommonTranslationItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("ID")]
        [StringLength(100)]
        public string Id { get; set; }
        [StringLength(2000)]
        public string Context { get; set; }
        public int? LastTransactionId { get; set; }
        [Column("proprietary")]
        public bool? Proprietary { get; set; }
    }
}
