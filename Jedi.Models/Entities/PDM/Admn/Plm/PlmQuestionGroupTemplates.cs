using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmQuestionGroupTemplates")]
    public partial class PlmQuestionGroupTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? OrderIndex { get; set; }
        [Column("QuestionGroupID")]
        [StringLength(80)]
        public string QuestionGroupId { get; set; }
        public bool? HasLookback { get; set; }
    }
}
