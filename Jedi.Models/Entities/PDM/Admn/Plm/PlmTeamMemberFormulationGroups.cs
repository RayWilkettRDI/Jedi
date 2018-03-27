using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmTeamMemberFormulationGroups")]
    public partial class PlmTeamMemberFormulationGroups
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkGroup", TypeName = "char(40)")]
        public string FkGroup { get; set; }
        [Column("RoleID", TypeName = "char(2)")]
        public string RoleId { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
