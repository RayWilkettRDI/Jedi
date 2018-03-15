using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmProjectTypes")]
    public partial class PlmProjectTypes
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTaxonomyNode", TypeName = "char(40)")]
        public string FkTaxonomyNode { get; set; }
        [StringLength(64)]
        public string FullName { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
