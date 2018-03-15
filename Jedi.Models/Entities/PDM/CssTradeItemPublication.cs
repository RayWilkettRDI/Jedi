using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cssTradeItemPublication")]
    public partial class CssTradeItemPublication
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTradingPartnerTaxonomy", TypeName = "char(40)")]
        public string FkTradingPartnerTaxonomy { get; set; }
        [Column("fkManufacturer", TypeName = "char(40)")]
        public string FkManufacturer { get; set; }
        public bool? IsGhost { get; set; }
        [StringLength(50)]
        public string NamespaceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [Column("fkTradeItem", TypeName = "char(40)")]
        public string FkTradeItem { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OriginationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InitialPubDate { get; set; }
        [Column("fkPermissionTemplate", TypeName = "char(40)")]
        public string FkPermissionTemplate { get; set; }
        [Column("fkProcessTemplate", TypeName = "char(40)")]
        public string FkProcessTemplate { get; set; }
        [Column("GTIN")]
        [StringLength(14)]
        public string Gtin { get; set; }
        [Column("fkWorkflowStatus", TypeName = "char(40)")]
        public string FkWorkflowStatus { get; set; }
        [Column("fkAncestor", TypeName = "char(40)")]
        public string FkAncestor { get; set; }
        [Column("fkTradingPartner", TypeName = "char(40)")]
        public string FkTradingPartner { get; set; }
        [Column("fkTargetMarket", TypeName = "char(40)")]
        public string FkTargetMarket { get; set; }
        [Column("fkInfoProvider", TypeName = "char(40)")]
        public string FkInfoProvider { get; set; }
        [Column("fkPublicationType", TypeName = "char(40)")]
        public string FkPublicationType { get; set; }
        [Column("fkGPCStatus", TypeName = "char(40)")]
        public string FkGpcstatus { get; set; }
        [Column("private")]
        public bool? Private { get; set; }
    }
}
