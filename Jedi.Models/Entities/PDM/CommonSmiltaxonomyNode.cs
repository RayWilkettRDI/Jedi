using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonSMILTaxonomyNode")]
    public partial class CommonSmiltaxonomyNode
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkTaxonomyNamespace", TypeName = "char(40)")]
        public string FkTaxonomyNamespace { get; set; }
        public int Status { get; set; }
        public int IsPhantom { get; set; }
        [Column("ExternalID")]
        [StringLength(200)]
        public string ExternalId { get; set; }
    }
}
