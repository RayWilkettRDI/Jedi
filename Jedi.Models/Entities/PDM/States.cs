using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class States
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(256)]
        public string Name { get; set; }
        public int? Status { get; set; }
        [StringLength(5)]
        public string IsoCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        public double? DexVersion { get; set; }
    }
}
