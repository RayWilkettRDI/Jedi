using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("PQSTemplate")]
    public partial class Pqstemplate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [Column("fkTestingProtocol", TypeName = "char(40)")]
        public string FkTestingProtocol { get; set; }
        [Column("LanguageID")]
        public int? LanguageId { get; set; }
        [Column("seqid")]
        public int? Seqid { get; set; }
    }
}
