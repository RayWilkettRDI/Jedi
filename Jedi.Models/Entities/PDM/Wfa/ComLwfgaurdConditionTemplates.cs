using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    [Table("comLWFGaurdConditionTemplates")]
    public partial class ComLwfgaurdConditionTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [StringLength(256)]
        public string GuardConditionInstanceFacUrl { get; set; }
        public int? RelatedState { get; set; }
        public int? RelatedStateChangeDirection { get; set; }
        public int? SortOrder { get; set; }
    }
}
