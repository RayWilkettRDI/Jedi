using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class UserChangeRequestAction
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Action { get; set; }
        [Column("fkGroup", TypeName = "char(40)")]
        public string FkGroup { get; set; }
        [Column("fkUserChangeRequest", TypeName = "char(40)")]
        public string FkUserChangeRequest { get; set; }
    }
}
