using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdProjectTypes")]
    public partial class NpdProjectTypes
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("fkTaxonomyNode", TypeName = "char(40)")]
        public string FkTaxonomyNode { get; set; }
        [StringLength(256)]
        public string FullName { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
