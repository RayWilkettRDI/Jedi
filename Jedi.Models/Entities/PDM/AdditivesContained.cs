using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class AdditivesContained
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkMaxPer100gUOM", TypeName = "char(40)")]
        public string FkMaxPer100gUom { get; set; }
        [Column("fkAdditive", TypeName = "char(40)")]
        public string FkAdditive { get; set; }
        public double? MaxPer100g { get; set; }
        public int? Status { get; set; }
        [Column("comments")]
        [StringLength(256)]
        public string Comments { get; set; }
    }
}
