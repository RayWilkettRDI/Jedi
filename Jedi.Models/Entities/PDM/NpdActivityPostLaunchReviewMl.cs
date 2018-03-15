using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdActivityPostLaunchReviewML")]
    public partial class NpdActivityPostLaunchReviewMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(300)]
        public string ProductionReviewRobustness { get; set; }
        [Column("SalesVolumesActualVSPlanned")]
        [StringLength(300)]
        public string SalesVolumesActualVsplanned { get; set; }
        [Column("fkNPDActivityPostLaunchReview", TypeName = "char(40)")]
        public string FkNpdactivityPostLaunchReview { get; set; }
        [StringLength(300)]
        public string ReviewProductEffectiveness { get; set; }
        [StringLength(300)]
        public string ProductionReviewScaleUpIssues { get; set; }
        [Column("ConsAndSalesKPIsIdentifyIssues")]
        [StringLength(300)]
        public string ConsAndSalesKpisIdentifyIssues { get; set; }
        [StringLength(100)]
        public string Platform { get; set; }
        [StringLength(300)]
        public string TradeReaction { get; set; }
        [StringLength(300)]
        public string Financials { get; set; }
        [Column("ConsumerAndSalesKPIsCompare")]
        [StringLength(300)]
        public string ConsumerAndSalesKpisCompare { get; set; }
        [Column("ConsumerAndSalesKPIs")]
        [StringLength(300)]
        public string ConsumerAndSalesKpis { get; set; }
        [StringLength(200)]
        public string Brands { get; set; }
        [StringLength(100)]
        public string ProductSponsor { get; set; }
        [StringLength(300)]
        public string SupplyChain { get; set; }
        [StringLength(300)]
        public string ConsumerComplaints { get; set; }
        [StringLength(300)]
        public string Competition { get; set; }
        [StringLength(300)]
        public string Quality { get; set; }
        [StringLength(300)]
        public string ValueEngineeringProjects { get; set; }
        [StringLength(100)]
        public string ProductCategory { get; set; }
        [StringLength(300)]
        public string ReviewProdEfectiveCouldImprove { get; set; }
        [StringLength(300)]
        public string ReviewProdEffectiveWorkedWell { get; set; }
        [StringLength(300)]
        public string Advertising { get; set; }
        [StringLength(100)]
        public string EuropeanOrLocal { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(300)]
        public string SalesVolumsTargetNext9Months { get; set; }
        [StringLength(300)]
        public string Promotions { get; set; }
    }
}
