using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class BomItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(40)]
        public string UomTag { get; set; }
        public int? SequenceNo { get; set; }
        [StringLength(80)]
        public string ItemId { get; set; }
        public int? Lvl { get; set; }
        [StringLength(40)]
        public string RevisionId { get; set; }
        public int? PackCount { get; set; }
        [StringLength(80)]
        public string RevisionObjectName { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
