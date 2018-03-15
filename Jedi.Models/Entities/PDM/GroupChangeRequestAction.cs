using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class GroupChangeRequestAction
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Action { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("fkGroupChangeRequest", TypeName = "char(40)")]
        public string FkGroupChangeRequest { get; set; }
    }
}
