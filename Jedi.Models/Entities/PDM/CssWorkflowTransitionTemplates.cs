using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cssWorkflowTransitionTemplates")]
    public partial class CssWorkflowTransitionTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsOtherwise { get; set; }
        [Column("fkFromActivityTemplate", TypeName = "char(40)")]
        public string FkFromActivityTemplate { get; set; }
        [Column("fkProcessTemplate", TypeName = "char(40)")]
        public string FkProcessTemplate { get; set; }
        public int? Sequence { get; set; }
        [Column("fkToActivityTemplate", TypeName = "char(40)")]
        public string FkToActivityTemplate { get; set; }
        public bool? IsUserVerificationRequired { get; set; }
        public bool? IsSigDocOverride { get; set; }
        public bool? IsCommentsRequired { get; set; }
    }
}
