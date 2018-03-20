using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Css
{
    [Table("cssTradingPartnerNodeML")]
    public partial class CssTradingPartnerNodeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(200)]
        public string Alias { get; set; }
        [Column("fkSMILTaxonomyNode", TypeName = "char(40)")]
        public string FkSmiltaxonomyNode { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
