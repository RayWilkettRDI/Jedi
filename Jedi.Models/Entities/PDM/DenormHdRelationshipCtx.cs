using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DENORM_HD_RELATIONSHIP_CTX")]
    public partial class DenormHdRelationshipCtx
    {
        [Key]
        [Column("PKID")]
        public int Pkid { get; set; }
        [StringLength(128)]
        public string Context { get; set; }
        public int MaxLevelLimit { get; set; }
        public int IsAlternate { get; set; }
    }
}
