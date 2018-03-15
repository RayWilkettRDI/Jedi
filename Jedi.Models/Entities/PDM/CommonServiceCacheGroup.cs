using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonServiceCacheGroup")]
    public partial class CommonServiceCacheGroup
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(80)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("langid")]
        public int Langid { get; set; }
    }
}
