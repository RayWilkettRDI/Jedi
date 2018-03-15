using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonLWFTransitions")]
    public partial class CommonLwftransitions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkProcess", TypeName = "char(40)")]
        public string FkProcess { get; set; }
        [Column("fkTransitionTemplate", TypeName = "char(40)")]
        public string FkTransitionTemplate { get; set; }
    }
}
