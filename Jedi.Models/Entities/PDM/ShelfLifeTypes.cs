using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ShelfLifeTypes
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("ID")]
        [StringLength(64)]
        public string Id { get; set; }
        public int? Status { get; set; }
        public int? SortOrder { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public double? DexVersion { get; set; }
    }
}
