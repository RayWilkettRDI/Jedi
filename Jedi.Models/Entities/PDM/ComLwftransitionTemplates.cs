using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFTransitionTemplates")]
    public partial class ComLwftransitionTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkToActivityTemplate", TypeName = "char(40)")]
        public string FkToActivityTemplate { get; set; }
        [Column("fkProcessTemplate", TypeName = "char(40)")]
        public string FkProcessTemplate { get; set; }
        [Column("fkFromActivityTemplate", TypeName = "char(40)")]
        public string FkFromActivityTemplate { get; set; }
        public bool? IsOtherwise { get; set; }
        public int? Sequence { get; set; }
        public bool? IsUserVerificationRequired { get; set; }
        public bool? IsSigDocOverride { get; set; }
        public bool? IsCommentsRequired { get; set; }
    }
}
