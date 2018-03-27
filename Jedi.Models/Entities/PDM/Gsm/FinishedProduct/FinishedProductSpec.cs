using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.FinishedProduct
{
    public partial class FinishedProductSpec
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("lasteditdate", TypeName = "char(10)")]
        public string Lasteditdate { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [Column("fkBrand", TypeName = "char(40)")]
        public string FkBrand { get; set; }
    }
}
