using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmQuestions")]
    public partial class PlmQuestions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("QuestionTypeID")]
        [StringLength(80)]
        public string QuestionTypeId { get; set; }
        [Column("QuestionID")]
        [StringLength(80)]
        public string QuestionId { get; set; }
        [Column("fkQuestionGroupTemplate", TypeName = "char(40)")]
        public string FkQuestionGroupTemplate { get; set; }
        public int? OrderIndex { get; set; }
        public bool? HasPullFromPrevious { get; set; }
        [StringLength(1000)]
        public string QuestionData { get; set; }
        [StringLength(1024)]
        public string ConfigValues { get; set; }
        [Column("fkQuestionRelation", TypeName = "char(40)")]
        public string FkQuestionRelation { get; set; }
    }
}
