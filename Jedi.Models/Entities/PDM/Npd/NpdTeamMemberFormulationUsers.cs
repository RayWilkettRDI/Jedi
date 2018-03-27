using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdTeamMemberFormulationUsers")]
    public partial class NpdTeamMemberFormulationUsers
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("RoleID", TypeName = "char(2)")]
        public string RoleId { get; set; }
        [Column("fkProject", TypeName = "char(40)")]
        public string FkProject { get; set; }
    }
}
