using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Css
{
    [Table("cssTradingPartnerNode")]
    public partial class CssTradingPartnerNode
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTaxonomyNamespace", TypeName = "char(40)")]
        public string FkTaxonomyNamespace { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkPublicationNamespace", TypeName = "char(40)")]
        public string FkPublicationNamespace { get; set; }
        public int? Status { get; set; }
        public int IsPhantom { get; set; }
    }
}
