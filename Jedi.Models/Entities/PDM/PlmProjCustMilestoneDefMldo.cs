using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmProjCustMilestoneDefMLDO")]
    public partial class PlmProjCustMilestoneDefMldo
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(32)]
        public string ShortName { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("fkProjCustomMilestoneDefault", TypeName = "char(40)")]
        public string FkProjCustomMilestoneDefault { get; set; }
        [Column("comments")]
        [StringLength(256)]
        public string Comments { get; set; }
    }
}
