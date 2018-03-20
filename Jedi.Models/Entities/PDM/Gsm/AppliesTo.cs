using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    public partial class AppliesTo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkMasterSpec", TypeName = "char(40)")]
        public string FkMasterSpec { get; set; }
        public int SpecType { get; set; }
        [Column("fkTaxonomyNode", TypeName = "char(40)")]
        public string FkTaxonomyNode { get; set; }
        [Column("fkTaxonomyNamespace", TypeName = "char(40)")]
        public string FkTaxonomyNamespace { get; set; }
    }
}
