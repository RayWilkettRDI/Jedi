using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFActionTemplates")]
    public partial class ComLwfactionTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string ActionInstanceFactoryUrl { get; set; }
        public int? RelatedStateChangeDirection { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        public int? RelatedState { get; set; }
        public int? SortOrder { get; set; }
    }
}
