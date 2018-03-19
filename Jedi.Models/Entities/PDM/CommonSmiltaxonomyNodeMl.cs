using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonSMILTaxonomyNodeML")]
    public partial class CommonSmiltaxonomyNodeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSMILTaxonomyNode", TypeName = "char(40)")]
        [Required]
        public string FkSmiltaxonomyNode { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Alias { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [ForeignKey("FkSmiltaxonomyNode")]
        public CommonSmiltaxonomyNode GetCommonSmiltaxonomyNode { get; set; }
    }
}
