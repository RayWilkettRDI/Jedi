using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("UOMCategory")]
    public partial class Uomcategory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("CategoryID")]
        [StringLength(5)]
        public string CategoryId { get; set; }
        public bool? IsValid { get; set; }
        public int? Sequence { get; set; }
    }
}
