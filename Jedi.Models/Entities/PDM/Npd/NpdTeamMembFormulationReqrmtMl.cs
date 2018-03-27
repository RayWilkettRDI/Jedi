using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdTeamMembFormulationReqrmtML")]
    public partial class NpdTeamMembFormulationReqrmtMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Guidance { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkTeamMemFormulationRqrmt", TypeName = "char(40)")]
        public string FkTeamMemFormulationRqrmt { get; set; }
    }
}
