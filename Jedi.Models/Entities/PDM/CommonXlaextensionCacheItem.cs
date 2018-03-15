using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonXLAExtensionCacheItem")]
    public partial class CommonXlaextensionCacheItem
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Id { get; set; }
        [StringLength(4000)]
        public string Value { get; set; }
    }
}
