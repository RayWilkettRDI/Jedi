using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdTeamMembFormulationReqrmts")]
    public partial class NpdTeamMembFormulationReqrmts
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsTeamMemberRequired { get; set; }
        public bool? IsAdditionalNotifyRequired { get; set; }
        [Column("fkFunctionalArea", TypeName = "char(40)")]
        public string FkFunctionalArea { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public bool? IsGateKeeperRequired { get; set; }
        [Column("fkAdditionalOwner", TypeName = "char(40)")]
        public string FkAdditionalOwner { get; set; }
        public int? SequenceNumber { get; set; }
    }
}
