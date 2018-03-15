using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SupportingDocuments
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [StringLength(128)]
        public string Documentname { get; set; }
        [Required]
        [Column(TypeName = "char(4)")]
        public string DocumentType { get; set; }
        [Column(TypeName = "char(40)")]
        public string Author { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
    }
}
