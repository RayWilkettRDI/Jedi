using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonLWFProcessResolutionSet")]
    public partial class CommonLwfprocessResolutionSet
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public int? Sequence { get; set; }
        [Column("dataSource")]
        [StringLength(256)]
        public string DataSource { get; set; }
        [Column("isAnd")]
        public bool? IsAnd { get; set; }
        [Column(TypeName = "char(1)")]
        public string MatchCriteria { get; set; }
        [Column("fkSigDocOverride", TypeName = "char(40)")]
        public string FkSigDocOverride { get; set; }
    }
}
