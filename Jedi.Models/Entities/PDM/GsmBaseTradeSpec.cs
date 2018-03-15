using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmBaseTradeSpec")]
    public partial class GsmBaseTradeSpec
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? ShelfLife { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AvailableDate { get; set; }
        public int? ItemType { get; set; }
        [Column("fkShelfLifeUOM", TypeName = "char(40)")]
        public string FkShelfLifeUom { get; set; }
        [Column("fkTradeType", TypeName = "char(40)")]
        public string FkTradeType { get; set; }
        [Column("lasteditdate", TypeName = "char(10)")]
        public string Lasteditdate { get; set; }
        [Column("fkTargetMarket", TypeName = "char(40)")]
        public string FkTargetMarket { get; set; }
        [Column("fkTradeProfileWorkflowStatus", TypeName = "char(40)")]
        public string FkTradeProfileWorkflowStatus { get; set; }
        [Column("fkMinStorageTempUOM", TypeName = "char(40)")]
        public string FkMinStorageTempUom { get; set; }
        public double? MaxStorageTemp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndAvailableDate { get; set; }
        public double? MinStorageTemp { get; set; }
        public bool? UsedByBestBeforeProduct { get; set; }
        [Column("fkMaxStorageTempUOM", TypeName = "char(40)")]
        public string FkMaxStorageTempUom { get; set; }
        [Column("fkActiveNutrientProfile", TypeName = "char(40)")]
        public string FkActiveNutrientProfile { get; set; }
        [Column("fkTheoreticalCost", TypeName = "char(40)")]
        public string FkTheoreticalCost { get; set; }
    }
}
