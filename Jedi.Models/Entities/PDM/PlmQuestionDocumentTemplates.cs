using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmQuestionDocumentTemplates")]
    public partial class PlmQuestionDocumentTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("QuestionDocumentID")]
        [StringLength(80)]
        public string QuestionDocumentId { get; set; }
        public bool? IsMasterTemplate { get; set; }
    }
}
