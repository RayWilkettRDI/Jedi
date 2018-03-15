using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmTeamMembFormulationReqrmtML")]
    public partial class PlmTeamMembFormulationReqrmtMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Guidance { get; set; }
        [Column("fkTeamMemFormulationRqrmt", TypeName = "char(40)")]
        public string FkTeamMemFormulationRqrmt { get; set; }
    }
}
