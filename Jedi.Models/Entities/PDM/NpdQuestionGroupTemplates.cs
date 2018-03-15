using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdQuestionGroupTemplates")]
    public partial class NpdQuestionGroupTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("QuestionGroupID")]
        [StringLength(80)]
        public string QuestionGroupId { get; set; }
        public int? OrderIndex { get; set; }
        public bool? HasLookback { get; set; }
    }
}
