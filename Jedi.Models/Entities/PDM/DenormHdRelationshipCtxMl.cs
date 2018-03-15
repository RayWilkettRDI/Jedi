using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DENORM_HD_RELATIONSHIP_CTX_ML")]
    public partial class DenormHdRelationshipCtxMl
    {
        [Column("PKID")]
        public int Pkid { get; set; }
        [Column("LangID")]
        public int LangId { get; set; }
        [StringLength(128)]
        public string Context { get; set; }
    }
}
