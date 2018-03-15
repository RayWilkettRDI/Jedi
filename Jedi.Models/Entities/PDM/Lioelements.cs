using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("LIOElements")]
    public partial class Lioelements
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSourceItem", TypeName = "char(40)")]
        public string FkSourceItem { get; set; }
        [StringLength(20)]
        public string DisplayFormatId { get; set; }
        public double? WaterInGrams { get; set; }
        [StringLength(2048)]
        public string ItemName { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public bool? HasBeenReconstituted { get; set; }
        public bool? IsDoNotDeclare { get; set; }
        public bool? DescendantHasBeenMoved { get; set; }
        public bool? HasBeenRenamed { get; set; }
        public double? DividedAmount { get; set; }
        [Column(TypeName = "char(40)")]
        public string SelectedBreakdownPkid { get; set; }
        public double? SolidsInGrams { get; set; }
        public bool? DescendantHasBeenReconstituted { get; set; }
    }
}
