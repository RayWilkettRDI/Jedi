using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Css
{
    [Table("cssTargetMarket")]
    public partial class CssTargetMarket
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("MarketID")]
        [StringLength(2)]
        public string MarketId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("fkCatalogAdminReviewRole", TypeName = "char(40)")]
        public string FkCatalogAdminReviewRole { get; set; }
    }
}
