using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("EQRequestTemplates")]
    public partial class EqrequestTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("EQRequestId", TypeName = "char(40)")]
        public string EqrequestId { get; set; }
        [StringLength(10)]
        public string QuestionaireType { get; set; }
    }
}
