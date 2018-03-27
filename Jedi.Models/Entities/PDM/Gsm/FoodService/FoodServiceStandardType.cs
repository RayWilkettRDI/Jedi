using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.FoodService
{
    public partial class FoodServiceStandardType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(100)]
        public string Locality { get; set; }
        [StringLength(100)]
        public string Compliance { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
