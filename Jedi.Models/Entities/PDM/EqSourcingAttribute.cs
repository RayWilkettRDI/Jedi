using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqSourcingAttribute")]
    public partial class EqSourcingAttribute
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkQuestionnaire", TypeName = "char(40)")]
        public string FkQuestionnaire { get; set; }
    }
}
