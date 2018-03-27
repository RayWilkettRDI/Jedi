using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmTeamMembFormulationReqrmts")]
    public partial class PlmTeamMembFormulationReqrmts
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAdditionalOwner", TypeName = "char(40)")]
        public string FkAdditionalOwner { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public bool? IsAdditionalNotifyRequired { get; set; }
        public bool? IsTeamMemberRequired { get; set; }
        [Column("fkFunctionalArea", TypeName = "char(40)")]
        public string FkFunctionalArea { get; set; }
        public bool? IsGateKeeperRequired { get; set; }
    }
}
